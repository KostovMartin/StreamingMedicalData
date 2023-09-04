namespace StreamingMedicalData;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("Host=192.168.1.10:5432; Database=medical_data; Username=postgres; Password=Sup3rn@tural");
    }

    public DbSet<Out> OutPatients { get; set; }
}