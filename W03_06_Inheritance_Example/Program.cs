using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_06_Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.Clear();
                ShowMenu();

                Console.Write("Choose an option: ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nDo you want to add a PC or a TV?");
                        string pctv = Console.ReadLine().ToUpper();

                        if (pctv == "PC")
                        {
                            Computer computer = new Computer();

                            Console.Write("Barcode: ");
                            computer.Barcode = Console.ReadLine();
                            Console.Write("Brand: ");
                            computer.Brand = Console.ReadLine();
                            Console.Write("Purchase Price: ");
                            computer.PurchasePrice = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Sell Price: ");
                            computer.SellPrice = Convert.ToDecimal(Console.ReadLine());
                            // PC Specific
                            Console.Write("Processor: ");
                            computer.Processor = Console.ReadLine();
                            Console.Write("Memory (GB): ");
                            computer.Memory = Convert.ToInt32(Console.ReadLine());
                            Console.Write("GPU: ");
                            computer.GPU = Console.ReadLine();

                            VirtualDB.AddPC(computer);
                            Console.WriteLine("Computer added.");

                            Console.WriteLine("Press a button to continue.");
                            Console.ReadKey();
                        }
                        else if (pctv == "TV")
                        {
                            TV tv = new TV();

                            Console.Write("Barcode: ");
                            tv.Barcode = Console.ReadLine();
                            Console.Write("Brand: ");
                            tv.Brand = Console.ReadLine();
                            Console.Write("Purchase Price: ");
                            tv.PurchasePrice = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Sell Price: ");
                            tv.SellPrice = Convert.ToDecimal(Console.ReadLine());
                            // TV Specific
                            Console.Write("Is it SmartTV? (Y/N)");
                            string yn = Console.ReadLine().ToUpper();
                            if (yn == "Y")
                                tv.SmartTV = true;
                            else
                                tv.SmartTV = false;
                            Console.Write("Does it have HDMI? (Y/N)");
                            yn = Console.ReadLine().ToUpper();
                            if (yn == "Y")
                                tv.HDMI = true;
                            else
                                tv.HDMI = false; ;
                            Console.Write("Screen Size: ");
                            tv.ScreenSize = Console.ReadLine();

                            VirtualDB.AddTV(tv);
                            Console.WriteLine("TV added.");

                            Console.WriteLine("Press a button to continue.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid type.");
                        }
                        break;

                    case 2:
                        VirtualDB.ShowProducts();

                        Console.WriteLine("Press a button to continue.");
                        Console.ReadKey();
                        break;

                    case 3:
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

            } while (option != 3);
        }

        static void ShowMenu()
        {
            Console.WriteLine("~~ MENU ~~");
            Console.WriteLine("1- Add Product");
            Console.WriteLine("2- Show Products");
            Console.WriteLine("3- Exit");
        }
    }
}
