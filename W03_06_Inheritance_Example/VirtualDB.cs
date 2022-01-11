using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_06_Inheritance_Example
{
    public static class VirtualDB
    {
        public static ArrayList db = new ArrayList();

        public static void AddProduct(Product product)
        {
            db.Add(product);
        }

        public static bool BarcodeExists(string barcode)
        {
            for (int i = 0; i < db.Count; i++)
            {
                Product product = (Product)db[i];
                if (product.Barcode == barcode)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddTV(TV tv)
        {
            db.Add(tv);
        }

        public static void AddPC(Computer pc)
        {
            db.Add(pc);
        }

        public static void ShowProducts()
        {
            foreach (var product in db)
            {
                if (product is Computer)
                {
                    Computer pc = (Computer)product;
                    Console.WriteLine($"\nID: {pc.ID}");
                    Console.WriteLine($"Brand: {pc.Brand}");
                    Console.WriteLine($"Sell Price: {pc.SellPrice}");
                    Console.WriteLine($"Processor: {pc.Processor}");
                    Console.WriteLine($"Memory: {pc.Memory} GB");
                    Console.WriteLine($"GPU: {pc.GPU}");
                }

                else if (product is TV)
                {
                    TV tv = (TV)product;
                    Console.WriteLine($"\nID: {tv.ID}");
                    Console.WriteLine($"Brand: {tv.Brand}");
                    Console.WriteLine($"Sell Price: {tv.SellPrice}");
                    Console.WriteLine($"SmartTV: {tv.SmartTV}");
                    Console.WriteLine($"HDMI: {tv.HDMI}");
                    Console.WriteLine($"Screen Size: {tv.ScreenSize}");
                }

                else
                {
                    Console.WriteLine("Something went wrong.");
                }
            }
        }

    }
}
