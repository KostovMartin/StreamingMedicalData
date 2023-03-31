using App.Metrics;
using App.Metrics.Timer;
using Confluent.Kafka;
using StreamingMedicalData;
using System.Text.Json;
using System.Xml.Serialization;

var metrics = new MetricsBuilder()
    .Report.ToConsole(
        options => {
            options.FlushInterval = TimeSpan.FromSeconds(60);
        })
    .Build();

var metricsOptions = new TimerOptions
{
    Context = "StreamingMedicalDataKafka",
    Name = "KafkaPatient"
};

var config = new ProducerConfig(new Dictionary<string, string>
{
    { "bootstrap.servers", "localhost:9092"},
    { "linger.ms", "75" },
    { "queue.buffering.max.messages", "100000"}
});

using var producer = new ProducerBuilder<Null, string>(config).Build();

var files = Directory.GetFiles("D:\\CP\\");
foreach (var file in files)
{
    string xmlString = File.ReadAllText(file);
    var serializer = new XmlSerializer(typeof(CpFile));
    using StringReader reader = new(xmlString);
    var cpFile = serializer.Deserialize(reader) as CpFile;

    foreach (var item in cpFile.In)
    {
        using (metrics.Measure.Timer.Time(metricsOptions))
        {
            string json = JsonSerializer.Serialize(item);
            var message = new Message<Null, string> { Value = json };
            producer.Produce("kafka-md-topic-in", message);
        }
    }

    foreach (var item in cpFile.Out)
    {
        using (metrics.Measure.Timer.Time(metricsOptions))
        {

            string json = JsonSerializer.Serialize(item);
            var message = new Message<Null, string> { Value = json };
            producer.Produce("kafka-md-topic-out", message);
        }
    }
};

await Task.WhenAll(metrics.ReportRunner.RunAllAsync());

SparkPostgresql.Start();
