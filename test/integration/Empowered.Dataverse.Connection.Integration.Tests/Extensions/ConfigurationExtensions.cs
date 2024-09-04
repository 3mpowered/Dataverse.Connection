using Microsoft.Extensions.Configuration;

namespace Empowered.Dataverse.Connection.Integration.Tests.Extensions;

public static class ConfigurationExtensions
{
    public static TValue GetRequiredValue<TValue>(this IConfiguration configuration, string key)
    {
        var value = configuration.GetValue<TValue>(key);
        if (value == null)
        {
            throw new InvalidOperationException($"{nameof(key)}: {key} is missing");
        }

        return value;
    }
}