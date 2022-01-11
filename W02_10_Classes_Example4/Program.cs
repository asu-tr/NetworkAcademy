using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_10_Classes_Example4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //double pi=Math.PI;
            //pi = Math.Round(pi,2);
            //Console.WriteLine(pi);

            Daire daire = new Daire();

            Console.Write("Dairenin yarıçapını giriniz:");
            daire.yaricap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dairenin alanı:" + daire.AlanHesapla(daire.yaricap));

            Console.WriteLine("Dairenin çevresi:" + daire.CevreHesapla(daire.yaricap));
            Console.ReadLine();
        }
    }
}