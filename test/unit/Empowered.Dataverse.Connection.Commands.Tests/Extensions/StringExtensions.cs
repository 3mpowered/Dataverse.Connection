using Spectre.Console;
using Spectre.Console.Testing;

namespace Empowered.Dataverse.Connection.Commands.Tests.Extensions;

public static class StringExtensions
{
    public static string ApplyMarkup(this string text)
    {
        var recorder = new Recorder(new TestConsole());
        recorder.Markup(text);
        return recorder.ExportText();
    }

}
