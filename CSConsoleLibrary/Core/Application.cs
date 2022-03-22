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
        protected ApplicationConfiguration Configuration { get; set; }
        protected ApplicationOptions Options { get; set; }
        private IWindowMimic Window { get; set; }
        private Stack<View> _views = new Stack<View>();
        private float _lastFrameTime = 0.0f;
        private bool Running { get; set; }
        private bool Minimized { get; set; }

        public Application()
        {
            // The derived client class overrides Options and Configuration if desired.
            Options = new ApplicationOptions() { ForegroundColor = ConsoleColor.White, BackgroundColor = ConsoleColor.Black };
            Configuration = new ApplicationConfiguration() { ApplicationName = "Application", PlatformType = ApplicationConfiguration.Platform.None, UseAuthorization = false};

            // Attempt to create the context. If a user is logged in while not authorized, reset.
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

            Console.ForegroundColor = Options.ForegroundColor;
            Console.BackgroundColor = Options.BackgroundColor;

            switch (Configuration.PlatformType)
            {
                case ApplicationConfiguration.Platform.None: Window = new WindowMimic(new WindowProperties(title: Configuration.ApplicationName)); break;
            }
        }

        public void Run()
        {
            Console.WriteLine("Running...");
            Running = true;
            while(Running)
            {
                float time = DateTime.Now.Millisecond / 1000.0f;
                Timestep ts = new Timestep(time - _lastFrameTime);
                _lastFrameTime = time;

                foreach (var view in _views)
                    view.OnUpdate(ts);

                Window?.OnUpdate(ts);
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

        public void PushView(View view)
        {
            _views.Push(view);
            view.OnAttach();
        }

        public void PopView()
        {
            var view = _views.Pop();
            view.OnDetach();
        }
    }
}
