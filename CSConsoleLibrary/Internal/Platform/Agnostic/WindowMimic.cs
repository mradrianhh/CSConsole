using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Internal.UI;

namespace CSConsoleLibrary.Internal.Platform.Agnostic
{
    internal sealed class WindowMimic : IWindowMimic
    {
        private struct WindowData
        {
            public string Title { get; set; }
            public uint Width { get; set; }
            public uint Height { get; set; }
            public bool Vsync { get; set; }
        }

        private WindowData _data;

        public WindowMimic(WindowProperties properties)
        {
            _data.Title = properties.Title;
            _data.Width = properties.Width;
            _data.Height = properties.Height;
        }

        public void OnUpdate()
        {
            Console.WriteLine("Updating window...");
        }

        public uint GetHeight()
        {
            return _data.Height;
        }

        public uint GetWidth()
        {
            return _data.Width;
        }

        public bool IsVsync()
        {
            return _data.Vsync;
        }

        public void SetVsync(bool enabled)
        {
            _data.Vsync = enabled;
        }
    }
}
