using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_04_Classes
{
    public class Client
    {
        public string TCKN;
        public string name;
        public string surname;
        public int sex; // Male 0, Female 1, Other 2

        public bool ClientCheck(string tcno)
        {
            // check database if that user exists.
            return true;
        }
    }
}