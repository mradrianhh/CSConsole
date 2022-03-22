using CSConsoleLibrary.Internal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Core;

namespace CSConsoleLibrary.UI
{
    public class View : IViewable
    {
        protected readonly string _identifier;
        public string Identifier { get => _identifier; }

        public View(string identifier = "View")
        {
            _identifier = identifier;
        }

        public virtual void OnUpdate(Timestep ts)
        {
            Console.WriteLine($"Updating from {Identifier}");
        }

        public virtual void OnAttach()
        {
            Console.WriteLine($"Attaching {Identifier}");
        }

        public virtual void OnDetach()
        {
            Console.WriteLine($"Detaching {Identifier}");
        }

        public override string ToString()
        {
            return Identifier;
        }

        
    }
}
