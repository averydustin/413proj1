using System;
using System.Collections.Generic;


namespace IS413Project1.Models.ViewModels
{
    public class AppointmentDef
    {
        public IEnumerable<Appointment> Taken { get; set; }

        public IEnumerable<Appointment> NotTaken { get; set; }

    }
}
