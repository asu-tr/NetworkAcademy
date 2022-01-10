using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_01_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WriteLine girilen değeri yazdıktan sonra alt satıra geçiyor.");
            Console.Write("Ama Write yazınca geçmiyor.");
            Console.ReadLine();

            // One-line comment

            /* MULTIPLE LINE COMMENT
             * 
             * TO MAKE ALL THE LINES COMMENT: CTRL + K + C 
             * TO UNDO THIS: CTRL + K + U
             */

            Console.Clear();

            string name;
            string nameSurname = "isim soyisim";

            Console.Write(nameSurname.ToLower()); // Opposite: ToUpper()
            Console.WriteLine(nameSurname.Substring(3, 7));
            Console.WriteLine(nameSurname.Substring(4));
            Console.ReadLine();

            char answer = 'E';

            // Integers
            int sayi1 = 5;
            byte sayi2 = 10; // Holds until 255.
            short sayi3 = 15;
            long sayi4 = 100;
            // ulong minValue: 0 - maxValue: long

            // Use these for min and max values:
            // int.MinValue; int.MaxValue;

            // Decimals
            float sayi5 = 10.5f;
            decimal sayi6 = 5.8m;
            double sayi7 = 3.9;

            bool logicalStatement = true; // Default value is false.

            DateTime birthday = DateTime.Now;

            string age = "50";
            int ageInt = Convert.ToInt32(age); // Returns 0 when value is null.
            int ageInt2 = Int32.Parse(age);

            var nameVar = "enes"; // name is now a string. Used with LINQ, usually.

            const float pi = 3.14f; // Constant cannot be changed.


            // Bilinçli (Explicit) Tür Dönüşümü. From bigger capacity to smaller capacity.
            byte k;
            int l = 100;

            k = (byte)l;

            // Bilinçsiz (Implicit) Tür Dönüşümü. From bigger capacity to smaller capacity.
            byte m = 200;
            int n = m;

            checked // Prevents the overflow and the runtime throws an OverflowException.
            {
                byte o;
                int p = 300;
                o = (byte)p;
            }
            // Unchecked - Ignore overflow

            Console.WriteLine("Deneme Başladı");
            string s = Console.Read().ToString(); // ASCII value of input.
            Console.WriteLine(s);
            Console.ReadLine();
            Console.ReadLine();


            // Object can get any type of value.

            object obj;
            obj = "bilgisayar";
            obj = 1; // Boxing

            int x = (int)obj; // Unboxing

        }
    }
}