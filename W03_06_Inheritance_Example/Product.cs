using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_06_Inheritance_Example
{
    public class Product
    {
        private static int id = 0;

        private int _id;
        public int ID
        {
            get { return _id; }
            private set { }
        }

        private string _barcode;
        public string Barcode
        {
            get { return _barcode; }
            set
            {
                if (value != null && !VirtualDB.BarcodeExists(value))
                {
                    _barcode = value;
                }
                else
                    Console.WriteLine("Invalid barcode.");
            }
        }

        public string Brand { get; set; }

        private decimal _purchasePrice;
        public decimal PurchasePrice
        {
            get { return _purchasePrice; }
            set
            {
                if (value > 0)
                {
                    _purchasePrice = value;
                }
                else
                    Console.WriteLine("Purchase price must be greater than 0.");
            }
        }

        private decimal _sellPrice;
        public decimal SellPrice
        {
            get { return _sellPrice; }
            set
            {
                if (value > PurchasePrice)
                    _sellPrice = value;
                else
                    Console.WriteLine("Sell price must be greater than purchase price.");
            }
        }

        public Product()
        {
            id++;
            this._id = id;
        }

    }
}
