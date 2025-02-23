using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApp.Persistance.Repositories;

namespace TaskManagementApp.Persistance;

public static class ServiceRegistrations
{
    public static void AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TaskManagementContext>(options =>
        {
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<IUserRepository, UserRepository>();
    }
}
