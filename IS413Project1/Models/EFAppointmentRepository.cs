using System;
using System.Linq;
namespace IS413Project1.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentDBContext _context;

        public EFAppointmentRepository(AppointmentDBContext context)
        {
            _context = context;
        }

        public IQueryable<Appointment> Appointments => _context.Appointments;

        public IQueryable<TimeSlot> TimeSlots => _context.TimeSlots;
    }
}
