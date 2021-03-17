using System;
namespace IS413Project1.Models
{
    public class TimeSlot
    {

        public int TimeSlotID { get; set; }

        public int? ApptID { get; set; }

        public string Day { get; set; }

        public string Time { get; set; }

        public string? description { get; set; }

         

    }
}
