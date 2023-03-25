using Microsoft.Spark.Sql;

namespace StreamingMedicalData;

internal class SparkPostgresql
{
    public static void Start()
    {
        SparkSession spark = SparkSession
            .Builder()
            .AppName("PatientUrgencyAggregation")
            .GetOrCreate();

        Dictionary<string, string> postgresProperties = new()
        {
            ["driver"] = "org.postgresql.Driver",
            ["user"] = "user",
            ["password"] = "password",
            ["url"] = "jdbc:postgresql://localhost:5432/medical_data"
        };

        DataFrame patientData = spark
            .Read()
            .Jdbc("jdbc:postgresql://localhost:5432/medical_data", "patient_data", postgresProperties)
            .Where("Severity IS NOT NULL");

        DataFrame extractedFields = patientData.Select("EGN", "Severity", "Delay", "Dead");
        extractedFields.CreateOrReplaceTempView("patient_data");

        DataFrame aggregatedData = spark.Sql("SELECT Severity, AVG(Delay), SUM(CAST(Dead AS INT)) FROM patient_data GROUP BY Severity");
        aggregatedData.Show();
        spark.Stop();
    }
}
