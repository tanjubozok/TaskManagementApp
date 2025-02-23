using Microsoft.Extensions.DependencyInjection;
using TaskManagementApp.Application.Requests;

namespace TaskManagementApp.Application.Extensions;

public static class ServiceRegistrations
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(LoginRequst).Assembly);
        });
    }
}