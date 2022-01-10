using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_01_Methods
{
    public class Student
    {
        public void StudentMethod1()
        {
            Console.WriteLine("Het is openbaar.");
        }

        private void StudentMethod2()
        {
            Console.WriteLine("Het is privaat.");
        }

        private int CalculateAverageGrade(int g1, int g2)
        {
            int avr = (g1 + g2) / 2;
            return avr;
        }

        public void AverageGrade(string name, string surname, int g1, int g2)
        {
            Console.Write($"Gemiddelde cijfer van {name} {surname} is {CalculateAverageGrade(g1, g2)}. ");

            if (CalculateAverageGrade(g1, g2) > 60)
            {
                Console.WriteLine("Ze/hij geslaagd voor de klas. Gefeliciteerd!");
            }

            else
                Console.WriteLine("Ze/hij heeft gezakt in de klas. Treurig :(");
        }
    }
}