using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.Core
{
    public sealed class Timestep
    {
        public float Time { get; set; }

        public Timestep(float time = 0.0f)
        {
            Time = time;
        }

        public float GetSeconds() { return Time; }
        public float GetMilliSeconds() { return Time * 1000.0f; }

        public static explicit operator float(Timestep ts)
        {
            return ts.Time;
        }
    }
}
