using App.Metrics;
using App.Metrics.Timer;
using Confluent.Kafka;
using StreamingMedicalData;
using System.Text.Json;
using System.Xml.Serialization;

var metrics = new MetricsBuilder()
    .Report.ToInfluxDb(
        options => {
            options.InfluxDb.BaseUri = new Uri("http://192.168.1.10:8086");
            options.InfluxDb.Database = "db";
            options.InfluxDb.UserName = "user";
            options.InfluxDb.Password = "password";
            options.FlushInterval = TimeSpan.FromSeconds(1);
        })
    .Build();

var metricsOptions = new TimerOptions
{
    Context = "StreamingMedicalDataKafka",
    Name = "Kafka"
};

var config = new ProducerConfig(new Dictionary<string, string>
{
    { "bootstrap.servers", "localhost:9092"},
    { "message.max.bytes", "1000000000"}
});
using var producer = new ProducerBuilder<Null, string>(config).Build();

var files = Directory.GetFiles("D:\\CP\\");
foreach (var file in files)
{
    using (metrics.Measure.Timer.Time(metricsOptions))
    {
        string xmlString = File.ReadAllText(file);
        var serializer = new XmlSerializer(typeof(CpFile));
        using StringReader reader = new(xmlString);
        var cpFile = serializer.Deserialize(reader) as CpFile;
        string cpFileJson = JsonSerializer.Serialize(cpFile);

        var message = new Message<Null, string> { Value = xmlString };
        var result = await producer.ProduceAsync("kafka-md-topic", message);
        //Console.WriteLine($"Produced message to: {result.TopicPartitionOffset}");
    }
}