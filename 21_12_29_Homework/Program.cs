using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_12_29_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan alınan cinsiyet bilgisine göre

            //==> ERKEK ise
            //    yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek,
            //    yaş 60'ın altında ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,   
            //    6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek

            //  ==> KADIN ise
            //     yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek,
            //     yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek, 
            //     5600 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek

            //     ==> cinsiyet bilgisi switch-case ile sorgulanacak

            char sex;
            int age, salary, workdays;

            do
            {
                Console.Write("Cinsiyet (K/E): ");
                sex = Convert.ToChar(Console.ReadLine());
            } while (sex != 'K' && sex != 'E');

            Console.Write("Yaş: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maaş: ");
            salary = Convert.ToInt32(Console.ReadLine());

            switch (sex)
            {
                case 'E':
                    if (age >= 60)
                    {
                        Console.WriteLine("Emeklilik ikramiyesi: " + (salary * 10));
                    }
                    else
                    {
                        Console.Write("Çalışılan gün sayısı: ");
                        workdays = Convert.ToInt32(Console.ReadLine());

                        if (workdays >= 6000)
                        {
                            Console.WriteLine("Emeklilik ikramiyesi: " + (salary * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emekli olamaz.");
                        }
                    }
                    break;

                case 'K':
                    if (age >= 58)
                    {
                        Console.WriteLine("Emeklilik ikramiyesi: " + (salary * 10));
                    }
                    else
                    {
                        Console.Write("Çalışılan gün sayısı: ");
                        workdays = Convert.ToInt32(Console.ReadLine());

                        if (workdays >= 5600)
                        {
                            Console.WriteLine("Emeklilik ikramiyesi: " + (salary * 11));
                        }
                        else
                        {
                            Console.WriteLine("Emekli olamaz.");
                        }
                    }
                    break;

                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}