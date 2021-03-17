using System;
using System.Linq;
namespace IS413Project1.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }

        IQueryable<TimeSlot> TimeSlots { get; }
    }

}
