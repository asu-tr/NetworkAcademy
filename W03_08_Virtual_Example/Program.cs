using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_08_Virtual_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank anybank = new Bank();
            anybank.Transfer();

            Enpara sweetie = new Enpara();
            sweetie.Transfer();

            Console.ReadLine();
        }
    }
}