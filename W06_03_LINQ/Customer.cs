using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_03_LINQ
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public string Country { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return FirstName + " - " + LastName + " - " + Country + " - " + BirthDate.Year.ToString();
        }
    }
}
