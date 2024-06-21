using System.Reflection;

namespace Util;

public static class AppDomainHelper
{
    public static IEnumerable<Assembly> GetLoadedAssemblies()
    {
        var loadedAssemblies = AppDomain
            .CurrentDomain
            .GetAssemblies()
            .Where(x => x.FullName != null && x.FullName.StartsWith("CQRS"));

        return loadedAssemblies;
    }
}
