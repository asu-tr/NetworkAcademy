using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_04_InnerType
{
    public class Order
    {
        static List<Order> Orders = new List<Order>();

        public int OrderID;
        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }
        public List<Product> OrderProducts = new List<Product>();

        public static void AddOrder(Order order)
        {
            if (order != null)
            {
                Orders.Add(order);
            }
        }

        public static int GetOrderCount()
        {
            return Orders.Count;
        }

        public static Order GetOrder(int id)
        {
            return Orders.Where(o => o.OrderID == id).FirstOrDefault();
        }
    }
}
