using System;
using System.Threading.Tasks;

namespace CSConsoleApp
{
    internal sealed class EntryPoint
    {
        static void Main()
        {
            ConsoleApplication app = new ConsoleApplication();

            app.Initialize();

            app.Run();
        }
    }
}
