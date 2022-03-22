using System;
using System.Threading.Tasks;

namespace CSConsoleApp
{
    internal sealed class EntryPoint
    {
        static async Task Main()
        {
            ConsoleApplication app = new ConsoleApplication();

            app.Initialize();

            await app.Run();
        }
    }
}
