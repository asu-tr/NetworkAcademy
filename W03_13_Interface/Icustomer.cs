using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_13_Interface
{
    public interface Icustomer
    {
        // no field here, only property
        int id { get; set; }
        string firstname { get; set; }
        string lastname { get; set; }

        // methods cannot have body
        int newrecord(string first, string last);
        int deleterecord(int id);
    }
}
