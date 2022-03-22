using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.Internal.UI
{
    internal sealed class WindowProperties
    {
        public string Title { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }

        public WindowProperties(string title = "Sandbox", uint width = 1600, uint height = 900)
        {
            Title = title;
            Width = width;
            Height = height;
        }
    }
}
