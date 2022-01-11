using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_04_Classes
{
    public class Car
    {
        public string marka;
        public string km;
        public int yil;
        public string yakit;
        public decimal alisFiyati;
        public decimal satisFiyati;

        public Car() // constructor method
        {
            yakit = "LPG";
        }

        public Car(int yil)
        {
            this.yil = yil;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Marka: {0}, KM: {1}, Yıl: {2}", marka, km, yil);
        }
    }
}