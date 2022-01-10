using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_01_Methods
{
    class Math
    {
        public void Menu()
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1- Toevoeging (+)");
            Console.WriteLine("2- Aftrekken (-)");
            Console.WriteLine("3- Vermenigvuldiging (*)");
            Console.WriteLine("4- Divisie (/)");
            Console.WriteLine("5- Faculteit (!)");
        }

        public decimal Addition(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal Subtraction(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal Multiplication(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal Division(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
        public double Factorial(int n)
        {
            if (n == 1)
                return 1;

            else
                return n * Factorial(n - 1);
        }
    }
}