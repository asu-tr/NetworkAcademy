using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace W11_03_DataAnnotations.Models
{
    public class User
    {
        public string Name { get; set; }

        [Required(ErrorMessage = "We need your age."), Range(10,90, ErrorMessage = "Age needs to be between {1} and {2}.")]
        public int Age { get; set; }

        private object Required()
        {
            throw new NotImplementedException();
        }

        [Required(ErrorMessage = "How can we identify you, if you don't have a username?"), MinLength(5, ErrorMessage = "Min is 5."), MaxLength(20, ErrorMessage = "Max is 20.")]
        public string Username { get; set; }

        [DisplayName("Password"), Required(), MinLength(6), MaxLength(10), DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Password again"), Required(), MinLength(6), MaxLength(10), DataType(DataType.Password), Compare(nameof(Password))]
        public string SecondaryPassword { get; set; }

        [DisplayName("E-mail"), Required()]
        public string Email { get; set; }

        [DisplayName("E-mail again"), Required(), Compare(nameof(Email))]
        public string SecondaryEmail { get; set; }

        public string Profession { get; set; }
    }
}