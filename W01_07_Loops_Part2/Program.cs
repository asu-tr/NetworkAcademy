using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_07_Loops_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sum of Inputs

            //int sum = 0, num;
            //do
            //{
            //    Console.Write("Toplanacak sayı: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //} while (num != 0);

            //Console.WriteLine("Toplam: " + sum);

            #endregion

            #region Check Username and Password

            //string username, pwd;
            //int count = 0;

            //do
            //{
            //    if (count >= 1)
            //    {
            //        Console.WriteLine("Hatalı kullanıcı adı veya şifre. Tekrar deneyin.\n");
            //    }

            //    Console.Write("Kullanıcı adı: ");
            //    username = Console.ReadLine();

            //    Console.Write("Şifre: ");
            //    pwd = Console.ReadLine();

            //    count++;
            //} while (username != "demo" || pwd != "demo");

            //Console.WriteLine("Giriş başarılı.");

            #endregion

            #region Random

            //Random rnd = new Random();
            //int rnd_num = rnd.Next(1, 10), input, counter = 0;

            //do
            //{
            //    counter++;
            //    Console.WriteLine(counter + ". Tahmininiz: ");
            //    input = Convert.ToInt32(Console.ReadLine());
            //} while (input != rnd_num);

            //Console.WriteLine("Doğru tahmin!");

            #endregion

            #region Do While Example

            //char yn, opr;
            //int n1, n2;

            //do
            //{
            //    Console.Clear();
            //    double result = 0.0;
            //    int err = 0;
            //    Console.Write("Birinci sayı: ");
            //    n1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("İkinci sayı: ");
            //    n2 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Operatör: ");
            //    opr = Convert.ToChar(Console.ReadLine());

            //    switch (opr)
            //    {
            //        case '+':
            //            result = n1 + n2;
            //            break;
            //        case '-':
            //            result = n1 - n2;
            //            break;
            //        case '*':
            //            result = n1 * n2;
            //            break;
            //        case '/':
            //            if (n2==0)
            //            {
            //                Console.WriteLine("Sıfıra bölünemez.");
            //                err++;
            //                break;
            //            }
            //            else
            //            {
            //                result = n1 / n2;
            //            }
            //            break;
            //        default:
            //            break;
            //    }

            //    if (err<1)
            //    {
            //        Console.WriteLine("Sonuç: " + result);
            //    }

            //    do
            //    {
            //        Console.WriteLine("Devam etmek ister misiniz? (E/H)");
            //        yn = Convert.ToChar(Console.ReadLine());
            //    } while (yn!='E' && yn!='H');

            //} while (yn == 'E');

            #endregion

            Console.ReadLine();
        }
    }
}