using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_02_Methods_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tax

            //Console.WriteLine("Ürün kategorisi (1/2/3): ");
            //int cat = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Fiyat: ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());

            //Tax tax = new Tax();
            //decimal kdv = tax.Calculate(productPrice, cat);

            //Console.Write("KDV: " + kdv.ToString());

            #endregion

            #region Array

            int[] array = RandomArray();

            PrintArray(array);

            #endregion

            Console.ReadLine();
        }

        static int[] RandomArray()
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
            }

            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}