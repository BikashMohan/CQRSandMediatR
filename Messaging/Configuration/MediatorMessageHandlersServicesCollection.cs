using Microsoft.Extensions.DependencyInjection;
using Util;

namespace Messaging.Configuration;

public static class MediatorMessageHandlersServicesCollection
{
    public static IServiceCollection AddMediatorMessageHandlers(this IServiceCollection services)
    {
        var loadedAssemblies = AppDomainHelper.GetLoadedAssemblies();

        foreach (var assembly in loadedAssemblies)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(assembly));
        }

        return services;
    }
}
