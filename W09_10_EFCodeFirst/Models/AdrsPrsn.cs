using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace W09_10_EFCodeFirst.Models
{
    public class AdrsPrsn
    {
        public List<Person> Persons { get; set; }
        public List<Address> Addresses { get; set; }
    }
}