using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413Project1.Models
{
    public class SignUp
    {
        [Required]
        public string NameOfGroup { get; set; }
        [Required]
        public int SizeOfGroup { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)[-.●]([0-9]{3})[-.●]([0-9]{4})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string PhoneNumber { get; set; }



    }
}
