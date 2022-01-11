using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_09_Classes_Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen Ogretmen1 = new Ogretmen();
            Ogretmen1.ID = 1;
            Ogretmen1.OgretmenAd = "Tee";
            Ogretmen1.OgretmenSoyad = "Cher";

            Ogrenci ogrenci1 = new Ogrenci() { TCNo = 123456789, OgrenciAd = "ali", OgrenciSoyad = "dede", okulNo = "12", sinifOgretmeni = Ogretmen1 };

            Ogretmen ogretmen2 = new Ogretmen() { ID = 2, OgretmenAd = "veli", OgretmenSoyad = "koca" };

            Ogrenci ogrenci2 = new Ogrenci() { TCNo = 123456789, OgrenciAd = "gürkan", OgrenciSoyad = "deniz", okulNo = "15", sinifOgretmeni = Ogretmen1 };

            Ogretmen1.ogrenciler.Add(ogrenci1);
            Ogretmen1.ogrenciler.Add(ogrenci2);

            Ogrenci ogrenci3 = new Ogrenci() { OgrenciAd = "betül", OgrenciSoyad = "yılmaz", TCNo = 123456789, okulNo = "20", sinifOgretmeni = ogretmen2 };

            ogretmen2.ogrenciler.Add(ogrenci3);

            Derslik d01 = new Derslik();

            d01.DerslikNo = 403;
            d01.kapasite = 2;
            d01.kat = 4;
            //d01.ogretmen = Ogretmen1;
            d01.OgretmenAta(Ogretmen1);

            Console.Write("Öğretmen adı:" + Ogretmen1.OgretmenAd);
            Console.Write("\nÖğretmen soyadı:" + Ogretmen1.OgretmenSoyad);
            Console.WriteLine("\nDerslik:" + d01.DerslikNo);

            foreach (var item in Ogretmen1.ogrenciler)
            {
                Console.WriteLine("Öğrenci:" + item.OgrenciAd + " " + item.OgrenciSoyad);

            }

            Console.ReadLine();
        }
    }
}