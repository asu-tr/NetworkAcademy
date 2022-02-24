using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08_02_EF_CodeFirst
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20), Required] // req == not null
        public string Name { get; set; }
        public int studentID { get; set; }
        public long TCKN { get; set; }
    }
}