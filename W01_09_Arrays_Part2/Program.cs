using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_09_Arrays_Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sort, Copy, Clear

            //int amount;
            //Console.Write("Şehir sayısı: ");
            //amount = Convert.ToInt32(Console.ReadLine());

            //string[] cities = new string[amount];

            //for (int i = 0; i < amount; i++)
            //{
            //    Console.Write($"{i+1}. Şehir: ");
            //    cities[i] = Console.ReadLine();
            //}

            //// Array.Reverse(cities);

            //Array.Sort(cities);

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //// int index = Array.IndexOf(sehirler, "Istanbul")

            //string[] countries = new string[amount];

            //// Copy 5 of cities starting at 0, to countries starting at 0
            //Array.Copy(cities, countries, 5);

            //// Copy 3 of cities starting at 2, to countries starting at 1
            //Array.Copy(cities, 2, countries, 1, 3);

            //// Copy cities to countries, starting at 4th index of countries
            //cities.CopyTo(countries, 4);

            //// Delete starting 0, amount
            //Array.Clear(cities, 0, cities.Length);

            #endregion

            #region 2-D Arrays - Cross with 1s

            //int[,] numbers2D = new int[5, 5];
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (i == j || i+j ==4)
            //        {
            //            numbers2D[i, j] = 1;
            //        }

            //        else
            //            numbers2D[i, j] = 0;
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(numbers2D[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 2-D Arrays - 121210000

            //int[,] num2D = new int[5, 5];

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (j == 0 || j == 4)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                num2D[i, j] = 1;
            //            }

            //            else
            //                num2D[i, j] = 2;
            //        }
            //    }
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(num2D[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 2-D Arrays - Sum of Row

            //int[,] num2D = new int[3, 4];
            //int sum, num;

            //for (int i = 0; i < 3; i++)
            //{
            //    sum = 0;

            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (j == 3)
            //        {
            //            num2D[i, j] = sum;
            //        }

            //        else
            //        {
            //            Console.Write("{0}. satır {1}. değeri giriniz: ", i + 1, j + 1);
            //            num = Convert.ToInt32(Console.ReadLine());
            //            num2D[i, j] = num;

            //            sum += num;
            //        }
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.Write(num2D[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 3-D Arrays - Filled with Random Numbers

            //int[,,] num3D = new int[2, 3, 4];
            //Random rnd = new Random();

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        for (int k = 0; k < 4; k++)
            //        {
            //            int num = rnd.Next(0, 9);
            //            num3D[i, j, k] = num;
            //        }
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{");
            //        for (int k = 0; k < 4; k++)
            //        {
            //            Console.Write(num3D[i, j, k] + " ");
            //        }
            //        Console.Write("}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.ReadLine();
        }
    }
}