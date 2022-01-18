using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04_03_Example_Product
{
    public class Product
    {
        public int ID;
        public string Title;
        public string Category;
        public string Author;
        public Image Image;

        public override string ToString()
        {
            return Title;
        }
    }
}