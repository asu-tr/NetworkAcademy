using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace W03_04_InnerType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerID = 1;
            customer.Name = "Вера";
            CustomerAddress customerAddress = new CustomerAddress() { AddressType = "Home", City = "Подольск", Region = "Московская", Address = "Революционный проспект, 65" };
            CustomerAddress customerAddress2 = new CustomerAddress() { AddressType = "Work", City = "Москва", Region = "Щербинка", Address = "Цветочная улица, 11" };
            customer.CustomerAddresses.Add(customerAddress);
            customer.CustomerAddresses.Add(customerAddress2);
            CustomerContact customerContact = new CustomerContact() { ContactType = "Personal", ContactInfo = "+7 (929) 560-71-85" };
            customer.CustomerContacts.Add(customerContact);

            Product product1 = new Product() { ProductID = 1, Name = "Bread", Price = 3.5m };
            Product product2 = new Product() { ProductID = 2, Name = "Egg (x15)", Price = 12.5m };
            Product product3 = new Product() { ProductID = 3, Name = "Sweater", Price = 89.99m };
            Product product4 = new Product() { ProductID = 4, Name = "Chocolate", Price = 5m };

            Product.AddProduct(product1);
            Product.AddProduct(product2);
            Product.AddProduct(product3);
            Product.AddProduct(product4);

            Thread.Sleep(5000);

            int selection = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("---MENU---");
                Console.WriteLine("1- New Order");
                Console.WriteLine("2- See Order");
                Console.WriteLine("3- Add Product"); // NOT AVAILABLE
                Console.WriteLine("4- Exit");
                Console.WriteLine("\nWhat would you like to do today?");
                selection = Convert.ToInt32(Console.ReadLine());

                List<Product> ShoppingCart = new List<Product>();

                switch (selection)
                {
                    case 1:

                        bool moreproducts = false;
                        do
                        {
                            Console.WriteLine("Which one do you want to buy?");
                            Product.ShowProducts();
                            int chosenProductID = Convert.ToInt32(Console.ReadLine());
                            ShoppingCart.Add(Product.GetProduct(chosenProductID));

                            Console.WriteLine("Do you want to buy something more? If not, your order will be completed. (Y/N)");
                            string yesno = Console.ReadLine();
                            if (yesno == "Y")
                                moreproducts = true;
                            else
                                moreproducts = false;

                        } while (moreproducts);

                        decimal sum = 0;
                        int count = 1;
                        foreach (Product p in ShoppingCart)
                        {
                            sum += p.Price;
                            Console.WriteLine($"{count}- {p.Name}");
                            count++;
                        }
                        
                        int id = Order.GetOrderCount()+1;
                        Order newOrder = new Order() { OrderID = id, CustomerID = 1, OrderProducts = ShoppingCart };
                        Order.AddOrder(newOrder);

                        Console.WriteLine($"Total price: {sum}. Your order ID: {newOrder.OrderID}. You will be redirected to the main page.");

                        Console.WriteLine("Press a button to continue.");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("What is your order ID?");
                        int orderID = Convert.ToInt32(Console.ReadLine());

                        Order currentOrder = Order.GetOrder(orderID);

                        Console.WriteLine("Order ID: " + currentOrder.OrderID);
                        Console.WriteLine("Order Items: ");

                        sum = 0;
                        count = 1;
                        foreach (Product product in currentOrder.OrderProducts)
                        {
                            sum += product.Price;
                            Console.WriteLine($"Product {count}: {product.Name}");
                            count++;
                        }
                        Console.WriteLine("Sum is: " + sum);

                        Console.WriteLine("Press a button to continue.");
                        Console.ReadKey();

                        break;

                    case 3:
                        Console.WriteLine("UNDER CONSTRUCTION");
                        Console.WriteLine("Press a button to continue.");
                        Console.ReadKey();
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

            } while (selection != 4);
        }
    }
}
