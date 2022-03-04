using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W09_10_EFCodeFirst.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        public virtual Person Person { get; set; }
    }
}