using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_08_Virtual_Example
{
    public class Bank
    {
        public double TransferFee;

        public virtual void Transfer()
        {
            Console.WriteLine("Transfer completed. Transfer fee: " + this.TransferFee);
        }

        public Bank()
        {
            TransferFee = 0;
        }
    }
}
