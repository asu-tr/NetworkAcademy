using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W06_07_CSV
{
    public class Employer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return ID.ToString() + " " + FirstName;
        }
    }
}
