using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_05_SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Which Month

            string ay = Console.ReadLine();

            switch (ay.ToLower())
            {
                case "ocak":
                    Console.WriteLine("1. Ay");
                    break;

                case "şubat":
                    Console.WriteLine("2. Ay");
                    break;

                case "mart":
                    Console.WriteLine("3. Ay");
                    break;

                default:
                    Console.WriteLine("İlk 3 ay değil.");
                    break;
            }

            #endregion

            #region Calculator

            Console.WriteLine("Birinci ve ikinci sayıyı giriniz:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem operatörünü giriniz:");
            string opr = Console.ReadLine();

            double result = 0;

            switch (opr)
            {
                case "+":
                    result = n1 + n2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case "-":
                    result = n1 - n2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case "*":
                    result = n1 * n2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case "/":
                    result = n1 / n2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                case "%":
                    result = n1 % n2;
                    Console.WriteLine("Sonuç: " + result);
                    break;

                default:
                    Console.WriteLine("HATA");
                    break;
            }

            #endregion

            #region Show Permissions

            Console.Write("Yetki kodunuz: ");
            string pCode = Console.ReadLine();

            Console.Write("YETKİ TÜRÜ: ");
            switch (pCode)
            {
                case "admin":
                    Console.WriteLine("TAM YETKİLİ");
                    break;

                case "AA":
                case "BB":
                    Console.WriteLine("SINIRLI YETKİ");
                    break;

                case "CC":
                    Console.WriteLine("YAZMA YETKİSİ");
                    break;

                case "DD":
                case "EE":
                    Console.WriteLine("OKUMA YETKİSİ");
                    break;

                default:
                    Console.WriteLine("YETKİ YOK");
                    break;
            }

            #endregion

            Console.ReadLine();
        }
    }
}