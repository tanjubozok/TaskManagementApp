using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaskManagementApp.Persistance.Context;

namespace TaskManagementApp.Persistance;

public static class ServiceRegistration
{
    public static void AddPersistanceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TaskManagementContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}
