using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_01_RentBike
{
    public class Bike
    {
        private int _id;
        private string _brand;
        private string _speed;
        private string _colour;


        public int ID
        {
            get { return _id; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }


    }
}
