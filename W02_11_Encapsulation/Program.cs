using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W02_11_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Kullanici k = new Kullanici();
                k.Ad = "yuri";
                k.Soyad = "lee";
                k.TCNO = "23455675901";
                k.TelNo = "5554441122";
                // k.email = "yurilee@hotmail.com";
                // k.Email = "yurilee@hotmail.com";

                Console.WriteLine(k.Email);
                Console.WriteLine("tc ilk 3 rakam: " + k.TCNO);
                Console.WriteLine("tel: " + k.TelNo);
                Console.WriteLine("ID: " + k.ID);

                Thread.Sleep(1);
                Kullanici k2 = new Kullanici();
                k2.Adres = " ";
                Console.WriteLine("Adres: " + k2.Adres);
                Console.WriteLine("ID: " + k2.ID);
                Console.WriteLine("Fiyat giriniz: ");
                k2.Fiyat = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("KDV'li fiyat: " + k2.KDVli);

            }
            catch (Exception)
            {

            }

            Console.ReadLine();
        }
    }
}