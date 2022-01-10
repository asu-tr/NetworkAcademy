using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_08_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays

            //string[] names = new string[5];
            //string[] studentID = { "11", "12", "13" };
            //names[0] = "Asude";

            #endregion

            #region Get Numbers and Print Them

            //Console.Write("Kaç sayı girmek istiyorsunuz: ");
            //int count = Convert.ToInt32(Console.ReadLine());

            //int[] nums = new int[count];
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write("Sayı giriniz: ");
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //    sum += nums[i];
            //}

            //Console.WriteLine("Toplam: " + sum);

            //Console.WriteLine("Girilen sayılar:");
            //foreach (var num in nums)
            //{
            //    Console.WriteLine(num);
            //}

            #endregion

            #region ReadKey

            //Console.WriteLine("Bir tuşa basınız.");
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //Console.WriteLine("\nBasılan tuş: " + keyInfo.Key);

            #endregion

            #region Example - 20 Random Numbers and Amount of 4s and Odds.

            //int[] myArray = new int[20];
            //Random rnd = new Random();
            //int numRnd, count = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    numRnd = rnd.Next(1, 10);
            //    myArray[i] = numRnd;
            //}

            //Console.WriteLine("Dizinin Elemanları:");
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.Write("{0}: {1}\n", i + 1, myArray[i]);
            //    if (myArray[i] == 4)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine("\nDizideki 4 adedi: " + count);

            //Console.WriteLine("\nDizideki Tek Sayılar:");
            //for (int i = 0; i < 20; i++)
            //{

            //    if (myArray[i] % 2 == 1)
            //    {
            //        Console.WriteLine(myArray[i]);
            //    }
            //}

            #endregion

            #region Example - Count Positive and Negative Numbers Randomly Generated Between -100 and 100.

            //int[] myNumArray = new int[20];
            //Random rnd = new Random();
            //int positiveNumCount = 0, negativeNumCount = 0, zeroNumCount = 0;

            //for (int i = 0; i < 20; i++)
            //{
            //    myNumArray[i] = rnd.Next(-100, 100);

            //    if (myNumArray[i] < 0)
            //        negativeNumCount++;

            //    if (myNumArray[i] > 0)
            //        positiveNumCount++;

            //    if (myNumArray[i] == 0)
            //        zeroNumCount++;
            //}

            //Console.WriteLine("Pozitif adedi: " + positiveNumCount);
            //Console.WriteLine("Negatif adedi: " + negativeNumCount);
            //Console.WriteLine("Sıfır adedi: " + zeroNumCount);

            #endregion

            #region Example - Vowels

            //char[] letters = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            //string inputText;
            //int count = 0;

            //Console.WriteLine("Sesli harf sayısını bulmak istediğiniz metni giriniz:");
            //inputText = Console.ReadLine();

            //foreach (char letter in inputText.ToLower())
            //{
            //    for (int i = 0; i < letters.Length; i++)
            //    {
            //        if (letter == letters[i])
            //        {
            //            count++;
            //        }
            //    }
            //}

            //Console.WriteLine("Sesli harf sayısı: " + count);

            #endregion

            #region Example - Count Numbers and Turkish Letters

            //string characters = "0123456789abcçdefgğhıijklmnoöprsştuüvyz";

            //Console.Write("Sorgulanacak metni giriniz: ");
            //string inputText = Console.ReadLine();
            //inputText = inputText.ToLower();

            //for (int i = 0; i < characters.Length; i++)
            //{
            //    int count = 0;

            //    for (int j = 0; j < inputText.Length; j++)
            //    {
            //        if (characters[i] == inputText[j])
            //        {
            //            count++;
            //        }
            //    }

            //    if (count > 0)
            //    {
            //        Console.WriteLine("Girilen metinde {0} karakterinden {1} adet var.", characters[i], count);
            //    }
            //}

            #endregion

            Console.ReadLine();

        }
    }
}