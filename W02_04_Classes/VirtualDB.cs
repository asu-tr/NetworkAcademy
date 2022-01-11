using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_04_Classes
{
    public class VirtualDB
    {
        ArrayList arrayList = new ArrayList();

        public void Register(int data)
        {
            arrayList.Add(data);
        }
    }
}