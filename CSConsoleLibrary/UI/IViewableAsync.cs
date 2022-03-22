using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.UI
{
    public interface IViewableAsync
    {
        public Task DisplayAsync();
    }
}
