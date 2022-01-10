using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_01_RentBike
{
    public class Rent
    {
        private int _id;
        private float _time;
        private float _price;
        private float _unitPrice;
        private DateTime _startDate;
        private DateTime _endDate;
        private User _user;
        private Bike _bike;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public float UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public User User
        {
            get { return _user; }
            set { _user = value; }
        }

        public Bike Bike
        {
            get { return _bike; }
            set { _bike = value; }
        }

        public void CalculatePrice()
        {
            TimeSpan ts = EndDate - StartDate;
            _time = ts.Seconds;
            UnitPrice = 0.05f;
            Price = _time * UnitPrice;

            ShowOnScreen();
        }

        public void ShowOnScreen()
        {
            Console.WriteLine("Dear {0}, you have to pay ${1}.", User.Name, Price);
        }

        public void RentStart()
        {
            _startDate = DateTime.Now;
        }

        public void RentFinish()
        {
            _endDate = DateTime.Now;
            CalculatePrice();
        }

    }
}
