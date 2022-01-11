using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_04_Classes
{
    internal class Program
    {
        // public herkese
        // private class içinde
        // protected kalıtım
        // internal sadece aynı namespace (kütüphane)
        // internal protected kütüphane ve kalıtım
        static void Main(string[] args)
        {
            #region Class - Client

            //Client client = new Client();

            //client.TCKN = "11111111111";
            //client.name = "Joseph";
            //client.surname = "Max";
            //client.sex = 0;

            //Client client1 = new Client();
            //client1 = client;

            //client1.TCKN = "111";
            //// now client.TCKN == "111"

            //client = null;
            //client1 = null;

            //client.ClientCheck(client.TCKN);

            //Console.WriteLine(client.TCKN);

            #endregion

            #region Class - Car

            //Car myCar = new Car();

            //myCar.marka = "Bugatti";
            //myCar.km = "50.000";
            //myCar.yil = 2019;
            //myCar.yakit = "Dizel";
            //myCar.alisFiyati = 25000;
            //myCar.satisFiyati = 50000;

            //myCar.PrintInfo();

            //Car car = new Car(2020);

            //car.marka = "Toyota";
            //car.km = "15.000";
            //car.alisFiyati = 15000;
            //car.satisFiyati = 20000;

            //Console.WriteLine(car.yakit);
            //Console.WriteLine(car.yil);

            #endregion

            #region List

            //// List<T> herhangi bir tip
            //List<int> list = new List<int>();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            #endregion

            #region Class - VirtualDB

            //VirtualDB db = new VirtualDB();
            //db.Register(10);
            //db.Register(20);

            #endregion

            Console.ReadLine();
        }
    }
}