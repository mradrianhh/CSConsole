using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSConsoleLibrary.Core;

namespace CSConsoleLibrary.UI
{
    internal interface IViewable
    {
        public void OnUpdate(Timestep ts);
    }
}
