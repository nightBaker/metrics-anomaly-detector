using MetricsAnomalyDetector.Domain;
using Microsoft.EntityFrameworkCore;

namespace MetricsAnomalyDetector.Persistence.Postgre;

public class PostgreDbContext : DbContext
{
    public PostgreDbContext(DbContextOptions<PostgreDbContext> options)
        : base(options)
    {

    }

    public DbSet<MetricStorage> MetricStorages { get; set; }
    public DbSet<AnomalyAnalayzer> AnomalyAnalayzers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}    
