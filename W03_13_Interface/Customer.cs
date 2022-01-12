using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_13_Interface
{
    public class Customer:BaseClass,Icustomer
    {
        public int id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string firstname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string lastname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int deleterecord(int id)
        {
            throw new NotImplementedException();
        }

        public int newrecord(string first, string last)
        {
            throw new NotImplementedException();
        }
    }
}
