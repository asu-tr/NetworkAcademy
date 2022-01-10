using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W01_10_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            //// type: object
            //ArrayList A1 = new ArrayList();

            //A1.Add("abc");
            //A1.Add(15);

            //ArrayList A2 = new ArrayList();

            //A2.Add(45);
            //A2.Add(23);
            //A2.Add(4354);
            //A2.Add(32);
            //A2.Add(456);

            //A1.AddRange(A2);

            //A2.Remove(45);

            //A2.RemoveRange(0, 2);

            //A2.RemoveAt(2);

            //A2.Sort();
            //A2.Reverse();

            //bool include = A2.Contains(15);
            //int ind = A1.IndexOf(15);

            //A1.Clear();      // Dizinin içini siler.
            //A1.TrimToSize(); // Dizinin kapasitesini min indirir.

            //object[] arr = A2.ToArray();

            #endregion

            #region Example - 1

            ArrayList arrayList = new ArrayList();

            arrayList.Add("10");
            arrayList.Add("5");
            arrayList.Add("234");
            arrayList.Add("234");
            arrayList.Add("2");
            arrayList.Add("546");
            arrayList.Add("67");
            arrayList.Add("10654");
            arrayList.Add("32423");
            arrayList.Add("123");

            int optionID = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("MENÜ");

                Console.WriteLine("1- Değer Ekle");
                Console.WriteLine("2- Değer Listele");
                Console.WriteLine("3- Değer Ara");
                Console.WriteLine("4- Değer Düzenle");
                Console.WriteLine("5- Değer Sil");
                Console.WriteLine("6- Çıkış");

                Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
                optionID = Convert.ToInt32(Console.ReadLine());

                string inputString;
                int inputInt;

                switch (optionID)
                {
                    case 1:

                        Console.Write("Eklemek istediğiniz değer: ");
                        inputString = Console.ReadLine();

                        arrayList.Add(inputString);

                        break;

                    case 2:

                        int count = 1;
                        foreach (var listItem in arrayList)
                        {
                            Console.WriteLine(count + "- " + listItem);
                            count++;
                        }

                        break;

                    case 3:

                        Console.Write("Aramak istediğiniz değer: ");
                        inputString = Console.ReadLine();

                        bool include = arrayList.Contains(inputString);

                        if (!include)
                        {
                            Console.WriteLine("Değer bulunamadı.");
                        }

                        else
                        {
                            int ind = arrayList.IndexOf(inputString);
                            Console.WriteLine($"Girilen değer ilk olarak {ind + 1}. sıradadır.");
                        }

                        break;

                    case 4:

                        Console.Write("Değiştirmek istediğiniz değerin sırası: ");
                        inputInt = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Yeni değer: ");
                        inputString = Console.ReadLine();

                        arrayList[inputInt - 1] = inputString;

                        break;

                    case 5:
                        Console.WriteLine("İşlem seçiniz: ");
                        Console.WriteLine("1- Belirli bir değeri sil");
                        Console.WriteLine("2- Belirli bir sıradaki değeri sil");
                        Console.WriteLine("3- Tüm değerleri sil");
                        inputInt = Convert.ToInt32(Console.ReadLine());

                        if (inputInt == 1)
                        {
                            Console.Write("Silinecek değer: ");
                            inputString = Console.ReadLine();

                            bool contains = arrayList.Contains(inputString);

                            while (contains)
                            {
                                arrayList.Remove(inputString);
                            }
                        }

                        else if (inputInt == 2)
                        {
                            Console.WriteLine("Silinecek değerin sırası: ");
                            inputInt = Convert.ToInt32(Console.ReadLine());

                            arrayList.RemoveAt(inputInt - 1);
                        }

                        else if (inputInt == 3)
                        {
                            arrayList.Clear();
                        }

                        else
                        {
                            Console.WriteLine("HATA");
                        }

                        break;

                    case 6:
                    default:
                        break;
                }

                Console.WriteLine("Devam etmek için bir tuşa basınız.");
                Console.ReadKey();


            } while (optionID != 6);

            #endregion

            Console.ReadLine();
        }
    }
}