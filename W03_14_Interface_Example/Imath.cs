using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_14_Interface_Example
{
    public interface Imath
    {
        decimal n1 { get; set; }
        decimal n2 { get; set; }

        decimal Calculate();
    }
}
