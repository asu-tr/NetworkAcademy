using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_03_Methods_Part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Example 1

            //Console.WriteLine("Büyük olan sayı: " + Bigger(30, 40));

            #endregion

            #region Prime Number

            //Console.Write("Asal olup olmadığına bakılacak sayı: ");
            //int input = Convert.ToInt32(Console.ReadLine());

            //if (PrimeNumber(input))
            //    Console.WriteLine("Asaldır.");

            //else
            //    Console.WriteLine("Asal değildir.");

            #endregion

            #region Odd Numbers in Array

            //int[] nums = { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            //Console.WriteLine("Tek sayılar: ");

            //nums = Odds(nums);

            //PrintArrayIfNotZero(nums);

            #endregion

            #region Sum (params int[] nums)

            //Sum(1, 2, 3, 4, 5, 6, 7, 8);

            #endregion

            #region Ref

            //// ref needs value, out not

            //int num = 0;

            //AssignValue(ref num);

            #endregion

            Console.ReadLine();
        }

        static void AssignValue(ref int incoming)
        {
            incoming = 10;
        }

        static void LocalFunction(int n1, int n2)
        {
            int Sum(int num1, int num2)
            {
                return num1 + num2;
            }

            Sum(n1, n2);
        }

        static void Sum(params int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);
        }

        static int Bigger(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static bool PrimeNumber(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static int[] Odds(int[] arr)
        {
            int[] odds = new int[arr.Length];
            int i = 0;

            foreach (int num in arr)
            {
                if (num % 2 == 1)
                {
                    odds[i] = num;
                    i++;
                }
            }

            return odds;
        }

        static void PrintArrayIfNotZero(int[] arr)
        {
            foreach (int num in arr)
            {
                if (num != 0)
                {
                    System.Console.WriteLine(num);
                }
            }
        }
    }
}