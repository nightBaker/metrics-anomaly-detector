using Microsoft.Extensions.DependencyInjection;


namespace MetricsAnomalyDetector.Persistence.Postgre;

public static class DependencyInjection
{
    public static IServiceCollection AddPostgrePersistence(this IServiceCollection services)
    {
        // Register PostgreSQL specific services here
        // For example, DbContext, repositories, etc.
        
        // Example: services.AddDbContext<MyDbContext>(options => options.UseNpgsql("YourConnectionString"));
        return services;
    }
}
