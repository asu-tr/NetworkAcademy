using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W03_01_RentBike
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.Name = "Joe";
            u1.Phone = "5554443322";

            Bike b1 = new Bike();
            b1.Brand = "Biky";
            b1.Speed = "21";
            b1.Colour = "Red";

            Rent r1 = new Rent();
            r1.User = u1;
            r1.Bike = b1;

            r1.RentStart();
            Thread.Sleep(1000);
            r1.RentFinish();

            Console.ReadLine();
        }
    }
}
