namespace TaskManagementApp.Application.Extensions;

public static class ServiceRegistrations
{
    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(LoginRequst).Assembly);
        });

        services.AddAutoMapper(typeof(MappingProfile));
    }
}