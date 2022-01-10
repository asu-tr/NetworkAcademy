using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_00_OnMyOwn
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example 1
            Console.WriteLine("Example 1\n");
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j + 1);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 2
            Console.WriteLine("\nExample 2\n");
            for (int i = 6; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 3
            Console.WriteLine("Example 3\n");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(j - i + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 4
            Console.WriteLine("Example 4\n");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 5
            Console.WriteLine("Example 5\n");
            int count = 1;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(count++ + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            // I skipped Example 6

            #region Example 7
            Console.WriteLine("Example 7\n");
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 8
            Console.WriteLine("\nExample 8\n");
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j < 6 - i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 6; k - 6 < i; k++)
                {
                    Console.Write(k - 5);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 9
            Console.WriteLine("\nExample 9\n");
            for (int i = 6; i > 1; i--)
            {
                for (int k = 1; k > i - 5; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 10
            Console.WriteLine("\nExample 10\n");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < (5 - i); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < i + 1; k++)
                {
                    Console.Write(k);
                }
                for (int k = i + 1; k > 0; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();
            }
            #endregion

            #region Example 11
            Console.WriteLine("\nExample 11\n");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            #endregion

            // I skipped Example 12

            #region Example 13
            Console.WriteLine("\nExample 13\n");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = i; k > -1; k--)
                {
                    Console.Write(k + " ");
                }
                for (int l = 1; l < i + 1; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }
            #endregion
            Console.ReadLine();
        }
    }
}