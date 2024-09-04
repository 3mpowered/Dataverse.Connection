using CommandDotNet.Spectre;
using Empowered.CommandLine.Extensions;
using Empowered.Dataverse.Connection.Commands;
using Empowered.Dataverse.Connection.Commands.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Spectre.Console;

namespace Empowered.Dataverse.Connection;

public static class Program
{
    public static int Main(string[] args) => GetAppRunner().Run(args);

    public static EmpoweredAppRunner<ConnectionCommand> GetAppRunner(IAnsiConsole? console = null)
    {
        var appRunner = new EmpoweredAppRunner<ConnectionCommand>("3mpwrd-connect",
            (collection, builder) => Configure(collection, builder, console));
        return appRunner;
    }

    private static void Configure(IServiceCollection collection, IConfigurationBuilder builder, IAnsiConsole? console)
    {
        if (console != null)
        {
            collection.TryAddSingleton(console);
        }

        collection.AddConnectionCommand();
    }
}
