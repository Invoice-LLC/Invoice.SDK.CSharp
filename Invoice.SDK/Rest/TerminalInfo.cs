﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice.SDK.Rest
{
    public struct TerminalInfo
    {
        public string id;
        public string link;
        public string name;
        public string alias;
        public string description;
        public TERMINAL_TYPE type;
        public double defaultPrice;
        public string error;
    }
}
