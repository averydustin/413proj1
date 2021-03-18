using System;
using System.Collections.Generic;

namespace IS413Project1.Models.ViewModels
{
    public class TimeSlotViewModel
    {
        public IEnumerable<TimeSlot> TimeSlots { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
        
        
    }
}
