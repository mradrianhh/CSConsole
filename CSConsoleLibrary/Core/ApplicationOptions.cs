using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.UI;

namespace CSConsoleLibrary.Core
{
    public struct ApplicationOptions
    {
        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
    }

    public static class ApplicationOptionsBuilder
    {
        public static ApplicationOptions CreateOptions()
        {
            return new ApplicationOptions();
        }

        public static ApplicationOptions SetForegroundColor(this ApplicationOptions options, ConsoleColor foregroundColor)
        {
            options.ForegroundColor = foregroundColor;
            return options;
        }

        public static ApplicationOptions SetBackgroundColor(this ApplicationOptions options, ConsoleColor backgroundColor)
        {
            options.BackgroundColor = backgroundColor;
            return options;
        }
    }
}
