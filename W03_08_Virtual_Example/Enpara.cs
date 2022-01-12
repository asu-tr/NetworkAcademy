using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_08_Virtual_Example
{
    public class Enpara:Bank
    {
        public Enpara()
        {
            TransferFee = 0.5;
        }

        public override void Transfer()
        {
            Console.WriteLine("Transfer to/from Enpara completed. Transfer fee: " + this.TransferFee);
        }
    }
}
