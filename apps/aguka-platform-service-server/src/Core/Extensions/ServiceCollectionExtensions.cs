using AgukaPlatformService.APIs;

namespace AgukaPlatformService;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IContactsService, ContactsService>();
        services.AddScoped<IExamplesService, ExamplesService>();
        services.AddScoped<IOpportunitiesService, OpportunitiesService>();
    }
}
