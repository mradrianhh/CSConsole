using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Internal;
using CSConsoleLibrary.Internal.UI;
using CSConsoleLibrary.UI;
using CSConsoleLibrary.Internal.Platform.Agnostic;
using CSConsoleLibrary.Internal.Core;

namespace CSConsoleLibrary.Core
{
    public class Application
    {
        private ApplicationContext Context { get; set; }
        protected ApplicationConfiguration? Configuration { get; set; }
        protected ApplicationOptions? Options { get; set; }
        private IWindowMimic? Window { get; set; }

        private bool Running { get; set; }
        private bool Minimized { get; set; }

        public Application()
        {
            try
            {
                ResetContext();
            }
            catch(UnauthorizedAccessException e)
            {
                Console.WriteLine(e.ToString());
                ResetContext();
            }
        }

        public void Initialize()
        {
            Console.WriteLine("Initializing...");

            if (Configuration == null)
                throw new ArgumentNullException("Configuration is not set. Set the Configuration for the application.");

            if (Options == null)
                throw new ArgumentNullException("Options is not set. Set the Options for the application.");

            switch (Configuration?.PlatformType)
            {
                case ApplicationConfiguration.Platform.None: Window = new WindowMimic(new WindowProperties()); return;
                default: throw new ArgumentException("Invalid platform type. Check configuration.");
            }
        }

        public void Run()
        {
            Console.WriteLine("Running...");
            Running = true;
            while(Running)
            {
            }
        }

        public void Close()
        {
            Console.WriteLine("Closing...");
            Running = false;
        }

        private void ResetContext()
        {
            Context = new ApplicationContext();
        }
    }
}
