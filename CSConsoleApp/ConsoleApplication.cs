using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Core;

namespace CSConsoleApp
{
    internal sealed class ConsoleApplication : Application
    {
        public ConsoleApplication() : base()
        {
            Configuration = ApplicationConfigurationBuilder.CreateConfiguration().SetApplicationName("Sandbox").UseAuthorization(false).SetPlatformType(ApplicationConfiguration.Platform.None);
            Options = ApplicationOptionsBuilder.CreateOptions().SetForegroundColor(ConsoleColor.Red).SetBackgroundColor(ConsoleColor.Black);
            PushView(new CSConsoleLibrary.UI.View());
        }
    }
}
