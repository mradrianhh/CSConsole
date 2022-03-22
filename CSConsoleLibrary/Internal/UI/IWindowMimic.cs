﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsoleLibrary.Internal.UI
{
    internal interface IWindowMimic
    {
        public void OnUpdate();
        public void SetVsync(bool enabled);
        public bool IsVsync();
        public uint GetWidth();
        public uint GetHeight();
    }
}
