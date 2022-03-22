using System.ComponentModel.DataAnnotations;

namespace W12_03_Filter.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(20)]
        public string Username { get; set; }

        [Required, StringLength(20), DataType(DataType.Password)]
        public string Password { get; set; }
    }
}