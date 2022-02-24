using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08_02_EF_CodeFirst
{
    public class Teacher
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20), Required]
        public string Name { get; set; }
        public long TCKN { get; set; }
        public Lecture Lecture { get; set; }
    }
}