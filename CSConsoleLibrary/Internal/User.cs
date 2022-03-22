using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.Internal
{
    internal sealed record User
    {
        public string Username { get; init; }
        public UserSettings Preferences { get; set; }
    }
}
