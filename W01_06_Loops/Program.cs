using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_06_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine( i+1 + "- This is a for loop.");
            //}

            #endregion

            int sum = 0;

            #region For Loop with Condition

            //for (int i = 0; i < 101; i++)
            //{
            //    if (i%2==1)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Some Math With For Loop

            //Console.WriteLine("toplanacak 10 sayı giriniz:");
            //sum = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    sum += a;
            //}
            //Console.WriteLine("Toplam: " + sum);

            #endregion

            #region Factorial

            //Console.WriteLine("Faktöriyelini hesaplamak istediğiniz sayı: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int result = 1;

            //for (int i = num; i > 1; i--)
            //{
            //    result *= i;
            //}

            //Console.WriteLine("Sonuç: " + result);

            #endregion

            #region Perfect Number ???

            //Console.WriteLine("Sayı: ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int result = 0;

            //for (int i = 1; i < input; i++)
            //{
            //    if (input % i == 0)
            //    {
            //        result += i;
            //    }
            //}

            //if (result == input)
            //{
            //    Console.WriteLine("Girilen sayı mükemmel sayıdır.");
            //}

            //else
            //    Console.WriteLine("Sayı mükemmel değildir.");

            #endregion

            #region Fibonacci

            //int f_num = 1;
            //int s_num = 1;
            //int t_num = 0;

            //Console.Write(f_num + " " + s_num + " ");
            //for (int i = 0; i < 10; i++)
            //{
            //    t_num = f_num + s_num;
            //    f_num = s_num;
            //    s_num = t_num;

            //    Console.Write(t_num + " ");
            //}

            #endregion

            #region Nested Loop

            #region Normal Triangle

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < (2*i)+1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("\n\n");

            #endregion

            #region Upper Right Triangle

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 10-i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Write("\n\n");

            #endregion

            #region Square

            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==0 || i==9)
            //    {
            //        for (int j = 0; j < 15; j++)
            //        {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }

            //    else
            //    {
            //        #region Option 1
            //        for (int j = 0; j < 15; j++)
            //        {
            //            if (j==0 || j==14)
            //            {
            //                Console.Write("*");
            //            }

            //            else
            //            {
            //                Console.Write(" ");
            //            }

            //        }
            //        Console.WriteLine();
            //        #endregion

            //        #region Option 2
            //        //Console.Write("*");
            //        //for (int j = 0; j < 13; j++)
            //        //{
            //        //    Console.Write(" ");
            //        //}
            //        //Console.WriteLine("*");
            //        #endregion
            //    }
            //}

            #endregion

            #region The Multiplication Table

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.Write("{0} x {1} = {2}\t", j, i, (i * j));
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Smallest, Biggest

            //int input, smallest = 0, biggest = 0;

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(i+1 + ". sayıyı giriniz: ");
            //    input = Convert.ToInt32(Console.ReadLine());

            //    if (i == 0)
            //    {
            //        smallest = input;
            //        biggest = input;
            //    }

            //    if (input <= smallest)
            //    {
            //        smallest = input;
            //    }

            //    if (input >= biggest)
            //    {
            //        biggest = input;
            //    }
            //}

            //Console.WriteLine("En büyük sayı: " + biggest + "\nEn küçük sayı: " + smallest);

            #endregion

            #endregion

            #region Endless Loop

            // int sayac = 0;
            //for (;;)
            //{
            //    sayac++;
            //    if (sayac == 100)
            //        break;    // döngüden çık
            //        continue; // sonraki döngüye başla
            //}

            #endregion

            #region Foreach

            //string[] names = new[] { "Halid", "Asu", "Rojda" };

            //foreach (var name in names)
            //{
            //    Console.WriteLine(name.ToUpper());
            //}

            #endregion

            #region While

            //int count = 0;
            //while (count < 10)
            //{
            //    count++;
            //    Console.Write(count + " ");
            //}

            #endregion

            #region Example - While

            //Console.WriteLine("Enter the number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //sum = num;

            //while (num >= 0)
            //{
            //    Console.WriteLine("Enter the number: ");
            //    num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 0)
            //    {
            //        break;
            //    }
            //    sum += num;
            //}
            //Console.WriteLine(sum);

            #endregion


            #region 2021-12-29 Asu-1 / Tree

            //Console.Write("Input number of rows for tree: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i < rows; i++)
            //{
            //    for (int j = 0; j < rows-i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 2021-12-29 Asu-2 / Number Tree

            //Console.Write("Input number of rows for number tree: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        Console.Write(i + 1 + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region 2021-12-29 Asu-3 / Harmonic Series

            //Console.WriteLine("Enter the number of terms for the harmonic series: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //double sum2 = 0.0;

            //for (int i = 0; i < rows; i++)
            //{
            //    Console.Write("1/"+(i+1)+" + ");
            //    sum2 += 1 / (float)(i + 1);
            //}
            //Console.WriteLine("\nSum is: " + sum2);

            #endregion

            #region 2021-12-29 Asu-4 / 9s

            //int my_num = 9;
            //Console.WriteLine("Enter the number of terms for 9s: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //sum = 0;

            //for (int i = 0; i < rows; i++)
            //{
            //    sum += my_num;
            //    Console.Write("{0} ", my_num);
            //    my_num = my_num * 10 + 9;
            //}

            //Console.WriteLine("\nSum is: " + sum);

            #endregion

            Console.ReadLine();
        }
    }
}