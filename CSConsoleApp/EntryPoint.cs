using System;
using System.IO;
using System.Diagnostics;
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
