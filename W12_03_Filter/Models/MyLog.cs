using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace W12_03_Filter.Models
{
    [Table("Logs")]
    public class MyLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required, StringLength(25)]
        public string Username { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public string Info { get; set; }
    }
}