//using Microsoft.Spark.Sql.Types;
//using Microsoft.Spark.Sql;

//namespace StreamingMedicalData;

//internal class SparkKafka
//{
//    public static void Start()
//    {
//        // Create a Spark session
//        var spark = SparkSession
//            .Builder()
//            .AppName("PatientUrgencyAggregation")
//            .GetOrCreate();

//        // Define the schema for the JSON data
//        var schema = new StructType(new[]
//        {
//            new StructField("EGN", new StringType()),
//            new StructField("Severity", new IntegerType()),
//            new StructField("Delay", new IntegerType()),
//            new StructField("Dead", new BooleanType())
//        });

//        // Read a stream of JSON records from Kafka
//        var kafkaConfig = new Dictionary<string, string>
//        {
//            {"bootstrap.servers", "localhost:9092"},
//            {"key.deserializer", "org.apache.kafka.common.serialization.StringDeserializer"},
//            {"value.deserializer", "org.apache.kafka.common.serialization.StringDeserializer"},
//            {"group.id", "patient-urgency-aggregation"},
//            {"auto.offset.reset", "latest"}
//        };

//        var parser = new JsonParser().GetOrCreate();


//        var kafkaTopics = new[] { "patient-urgency" };
//        var patientData = spark
//            .ReadStream()
//            .Format("kafka")
//            .Options(kafkaConfig)
//            .Load()
//            .SelectExpr("CAST(value AS STRING)")
//            .Select(from_json(Col("value"), schema).Alias("data"))
//            .Select("data.*")
//            .Where("Severity IS NOT NULL");

//        // Aggregate by patient urgency and calculate the average time waited and the number of deaths
//        var aggregatedRecords = records
//            .GroupBy(record => record.GetAs<string>("patient_urgency"))
//            .Agg(
//                SparkFunctions.Avg("time_waited").As("AverageTimeWaited"),
//                SparkFunctions.Sum(SparkFunctions.Col("patient_died").Cast("long")).As("NumDeaths")
//            )
//            .Select(
//                SparkFunctions.Col("key").As("PatientUrgency"),
//                SparkFunctions.Col("AverageTimeWaited"),
//                SparkFunctions.Col("NumDeaths")
//            )
//            .WriteStream
//            .Format("console")
//            .Option("truncate", "false")
//            .Start();
//    }
//}
