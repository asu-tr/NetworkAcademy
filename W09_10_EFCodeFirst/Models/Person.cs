using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace W09_10_EFCodeFirst.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual List<Address> AddressList { get; set; }
    }
}