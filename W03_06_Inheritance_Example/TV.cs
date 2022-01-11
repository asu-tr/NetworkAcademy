using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_06_Inheritance_Example
{
    public sealed class TV:Product
    {
        public bool SmartTV { get; set; }
        public bool HDMI { get; set; }
        public string ScreenSize { get; set; }
    }
}
