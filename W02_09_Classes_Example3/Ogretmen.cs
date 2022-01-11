using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_09_Classes_Example3
{
    public class Ogretmen
    {
        public int ID;
        public string OgretmenAd;
        public string OgretmenSoyad;
        public List<Ogrenci> ogrenciler = new List<Ogrenci>();
    }
}