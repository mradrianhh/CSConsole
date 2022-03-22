using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Internal;
using CSConsoleLibrary.UI;

namespace CSConsoleLibrary
{
    public class Application
    {
        private ApplicationContext _context;
        private ApplicationContext Context { get => _context; set => _context = value; }
        protected ApplicationConfiguration Configuration { get; set; } = default;
        protected ApplicationOptions Options { get; set; } = default;

        private bool _running;

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
        }

        public async Task Run()
        {
            Console.WriteLine("Running...");
            _running = true;
            while(_running)
            {
                await Context.CurrentView.DisplayAsync();
            }
        }

        public void Close()
        {
            Console.WriteLine("Closing...");
            _running = false;
        }

        private void ResetContext()
        {
            Context = new ApplicationContext();
        }
    }
}
