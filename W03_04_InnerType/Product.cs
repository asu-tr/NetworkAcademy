using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_04_InnerType
{
    public class Product
    {
        static List<Product> Products = new List<Product>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static void AddProduct(Product product)
        {
            if (product != null)
            {
                Products.Add(product);
            }
        }

        public static void ShowProducts()
        {
            Console.WriteLine("PRODUCTS: ");
            foreach (Product product in Products)
            {
                Console.WriteLine($"{product.ProductID}- {product.Name}: {product.Price}");
            }
        }

        public static Product GetProduct(int id)
        {
            return Products.Where(p => p.ProductID == id).FirstOrDefault();
        }
    }
}
