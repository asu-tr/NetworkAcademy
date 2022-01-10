using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_03_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2021-12-28

            #region Plus Opeartor

            int n1 = 15;
            int n2 = 25;
            int sum = n1 + n2;

            string name = "Asu";
            string surname = "Toros";
            int year = 1997;
            string fullname = name + " " + surname + ", " + year;
            Console.WriteLine(fullname);
            //Console.ReadLine();

            #endregion

            #region Example

            Console.WriteLine("Merhaba,");
            Console.Write("Adınız: ");
            name = Console.ReadLine();
            Console.Write("Soyadınız: ");
            surname = Console.ReadLine();
            Console.Write("Doğum yılınız: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int this_year = DateTime.Now.Year;
            Console.WriteLine("Merhaba " + name + " " + surname + ", " + (this_year - year) + " yaşındasınız.");
            Console.ReadLine();

            #endregion

            #region Star (Multiply) Operator

            double n3 = 10.2;
            double n4 = 5.8;
            double multiplication = n3 * n4;

            #endregion

            #region Divide Operator

            n1 = 15; // int n1
            n2 = 5;  // int n2
            int divide = n1 / n2; // = 3

            #endregion

            #region Modulus Operator

            int mod = n1 % n2; // 15 % 5 = 0
            mod = n1 % 4; // 15 % 4 = 3

            #endregion

            #region ++ Operator

            n1 = 5;
            n2 = n1++;
            Console.WriteLine(n2); // 5
            n1 = 5;
            n2 = ++n1;
            Console.WriteLine(n2); // 6
            Console.ReadLine();

            n1 = n1 + 1;
            n1++;
            n1 += 1;

            #endregion

            #region Comparison

            n1 = 10;
            n2 = 15;
            bool is_smaller = n1 < n2; // True
            bool is_bigger = n1 > n2; // False
            bool is_equal = n1 == n2; // False
            n2 = 10;
            bool is_equal_or_smaller = n1 <= n2; // True
            bool is_equal_or_bigger = n1 >= n2; // True
            bool is_not_equal = n1 != n2; // False

            #endregion

            #region is Operator

            int x = 50;
            object o1 = x;
            n1 = (int)o1;

            bool value = o1 is int;
            bool value2 = o1 is byte;
            bool value3 = o1 is string;

            #endregion

            #region as Operator

            object o2 = "İstanbul";
            string st = o2 as string; // unboxing

            #endregion

            #region Example

            Console.WriteLine("Sınav notlarını giriniz: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int n5 = Convert.ToInt32(Console.ReadLine());

            double ave = (n1 + n2 + n5) / 3;

            if (ave >= 50)
            {
                Console.WriteLine("Ortalama 50'den büyük veya eşit.");
            }

            else
                Console.WriteLine("Ortalama 50'den küçük.");

            Console.ReadLine();

            #endregion

            #region Logical Operators

            // && AND - BOTH TRUE
            // || OR 

            #endregion
        }
    }
}