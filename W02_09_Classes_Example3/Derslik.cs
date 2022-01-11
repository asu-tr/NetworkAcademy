using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_09_Classes_Example3
{
    public class Derslik
    {
        public int DerslikNo;
        public byte kapasite;
        public byte kat;
        public Ogretmen ogretmen;

        public void OgretmenAta(Ogretmen ogrt)
        {
            int ogrencisayisi = ogrt.ogrenciler.Count();

            if (ogrencisayisi <= kapasite)
            {
                this.ogretmen = ogrt;
            }
            else
                Console.WriteLine("Öğrenci sayısı sınıf kapasitesini aştığı için atama yapılamadı.");
        }
    }
}