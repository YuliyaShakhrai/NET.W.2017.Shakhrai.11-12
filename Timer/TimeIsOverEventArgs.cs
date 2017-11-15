using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public sealed class TimeIsOverEventArgs : EventArgs
    {
        public string Msg { get; set; }
    }
}
