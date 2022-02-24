using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08_02_EF_CodeFirst
{
    [Table("Parents")]
    public class Parent
    {
        [Key]
        public int ParentID { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }

        [StringLength(20), Required]
        public string Phone { get; set; }

        [StringLength(40)]
        public string Address { get; set; }
    }
}
