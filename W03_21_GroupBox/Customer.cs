using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_21_GroupBox
{
    public class Customer
    {
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string Phone;
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
