using Microsoft.EntityFrameworkCore;

namespace KubeTest.DataBase;

public static class DependencyInjection
{
    public static void InjectServices(this IServiceCollection services, ConfigurationManager configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<KubeTestContext>(options =>
            options.UseNpgsql(connectionString));
        services.AddHttpClient();
    }
}