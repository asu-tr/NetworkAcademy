using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W10_01_AutoStoredProcedure.Models
{
    public class Computer
    {
        public int Id { get; set; }
        [StringLength(15)]
        public string Brand { get; set; }
        public string GPU_ { get; set; }
    }
}