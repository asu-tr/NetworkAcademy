using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_10_Classes_Example4
{
    public class Daire
    {
        public double yaricap;
        private double pisayisi;

        public Daire()
        {
            pisayisi = 3;
        }
        ~Daire()
        {
            //Yıkıcı metot
        }
        public double AlanHesapla(double yaricapdisardangelen)
        {
            double alan = pisayisi * Math.Pow(yaricapdisardangelen, 2);
            return alan;
        }

        public double CevreHesapla(double yaricap)
        {
            return 2 * yaricap * pisayisi;
        }
    }
}