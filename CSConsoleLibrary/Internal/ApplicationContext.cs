using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.UI;

namespace CSConsoleLibrary.Internal
{
    internal sealed class ApplicationContext
    {
        private IViewableAsync _currentView;
        public IViewableAsync CurrentView
        {
            get => _currentView;
            set
            {
                if (value == null)
                    _currentView = new View("Default");
                else
                    _currentView = value;
            }
        }

        private User CurrentUser { get; set; } = default;
        private bool Authorized { get; set; }

        public ApplicationContext()
        {
            CurrentView = new View("Default");
            if (CurrentUser != null && !Authorized) 
                throw new UnauthorizedAccessException("Unauthorized user access.");
        }
    }
}
