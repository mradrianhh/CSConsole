using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.UI;
using CSConsoleLibrary.Internal.UI;
using CSConsoleLibrary.Internal.Auth;

namespace CSConsoleLibrary.Internal.Core
{
    internal sealed class ApplicationContext
    {
        public IWindowMimic Window { get; set; }
        public User CurrentUser { get; set; }
        public bool Authorized { get; set; }

        public ApplicationContext(IWindowMimic window = null, User user = null, bool authorized = false)
        {
            Window = window;
            CurrentUser = user;
            Authorized = authorized;
        }
    }
}
