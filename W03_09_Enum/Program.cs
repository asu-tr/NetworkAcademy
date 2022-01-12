using System;
using System.Threading;

namespace W03_09_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(1000);

            Animal dog = new Animal();
            dog.ID = "01";
            dog.Name = "Chucky";
            dog.Race = race.German_Shepherd;
            
            Animal dog2 = new Animal();
            dog.ID = "02";
            dog.Name = "Karabas";
            dog.Race = race.Siberian_Husky;
            dog.Race = (race)2;

            string raceInfo = Enum.GetName(typeof(race), dog.Race);
            string[] raceArray = Enum.GetNames(typeof(race));

            Console.WriteLine("HEY");

            Console.ReadKey();
        }
    }
}