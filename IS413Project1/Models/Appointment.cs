using System;
using System.ComponentModel.DataAnnotations;

namespace IS413Project1.Models
{
    public class Appointment
    {
        [Key]
        public int ApptID { get; set; }

        [Required]
        public string ApptTime { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }
    }
}
