using System;
using System.ComponentModel.DataAnnotations;

namespace IS413Project1.Models
{
    public class Appointment
    {
        [Timestamp]
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
