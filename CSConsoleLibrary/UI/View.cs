using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.UI
{
    public class View : IViewableAsync
    {
        protected readonly string _identifier;
        public string Identifier { get => _identifier; }

        public View(string identifier)
        {
            _identifier = identifier;
        }

        public virtual async Task DisplayAsync()
        {
            Console.WriteLine($"Displaying {Identifier}");
            await AwaitResponseAsync();
        }

        protected virtual async Task AwaitResponseAsync()
        {
            await Task.Delay(5000);
        }

        public override string ToString()
        {
            return Identifier;
        }
    }
}
