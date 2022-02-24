using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W08_02_EF_CodeFirst
{
    public class Lecture
    {
        [Key]
        public int ID { get; set; }

        [StringLength(20), Required] // req == not null
        public string LectureName { get; set; }
        public byte Hour { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
