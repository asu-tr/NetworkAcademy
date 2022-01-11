using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_08_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 20;
            int sayi2 = 0;
            int bolum = 0;

            try
            {
                bolum = sayi1 / sayi2;
                Console.WriteLine(bolum);
                // Hata yoksa bu kısım çalışır
            }
            //catch (Exception hata)
            //{
            //    Console.WriteLine(hata.Message);         //Console.WriteLine("Program çalışma esnasında bir hata ile karşılaştı.");
            //    //Hata alırsa bu kısım çalışır
            //}
            //catch (DivideByZeroException hata)
            //{
            //    Console.WriteLine(hata.Message);
            //}
            catch (FormatException hata)
            {
                Console.WriteLine(hata.Message);
            }

            finally
            {
                //Her durumda çalışır.
            }

            Console.ReadLine();
        }
    }
}