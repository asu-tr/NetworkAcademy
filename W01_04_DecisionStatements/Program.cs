using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_04_DecisionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ortalamaya Göre Kalma /Geçme

            Console.Write("Ortalama giriniz: ");
            int avr = Convert.ToInt32(Console.ReadLine());
            if (avr > 60)
            {
                Console.WriteLine("Geçtiniz.");
            }
            else if (avr <= 60 && avr >= 45)
            {
                Console.WriteLine("Sorumlu geçtiniz.");
            }
            else
            {
                Console.WriteLine("Kaldınız.");
            }

            #endregion

            #region Like Calculator

            Console.Write("Birinci sayı: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayı: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem operatörü: ");
            string ch = Console.ReadLine();

            double result = 0;

            bool noerror = true;

            if (ch == "+")
            {
                result = n1 + n2;
            }

            else if (ch == "-")
            {
                result = n1 - n2;
            }

            else if (ch == "*")
            {
                result = n1 * n2;
            }

            else if (ch == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Sıfıra bölünemez.");
                    noerror = false;
                }
                else
                    result = n1 / n2;
            }

            else if (ch == "%")
            {
                result = n1 % n2;
            }

            else
                Console.WriteLine("HATA!");
            if (noerror)
            {
                Console.WriteLine("Sonuç: " + result);
            }

            #endregion

            #region Examples

            int input = Convert.ToInt32(Console.ReadLine());

            #region Positive or Negative?

            if (input < 0)
            {
                Console.WriteLine("Sayı negatiftir.");
            }

            else if (input == 0)
            {
                Console.WriteLine("Sayı sıfırdır.");
            }

            else if (input > 0)
            {
                Console.WriteLine("Sayı pozitiftir.");
            }

            else
            {
                Console.WriteLine("HATA");
            }

            #endregion

            #region Even or Odd?
            if (input % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }

            else if (input % 2 == 0)
            {
                Console.WriteLine("Sayı tektir.");
            }

            else
            {
                Console.WriteLine("HATA");
            }
            #endregion

            #region Digit Count
            if (input < 10)
            {
                Console.WriteLine("Sayı 1 basamaklıdır.");
            }
            else if (input < 100)
            {
                Console.WriteLine("Sayı 2 basamaklıdır.");
            }
            else if (input < 1000)
            {
                Console.WriteLine("Sayı 3 basamaklıdır.");
            }
            else if (input >= 1000)
            {
                Console.WriteLine("Sayı çok basamaklıdır.");
            }
            else
                Console.WriteLine("HATA");
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}