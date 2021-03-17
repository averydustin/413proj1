using System;
using Microsoft.EntityFrameworkCore;
namespace IS413Project1.Models
{
    public class AppointmentDBContext : DbContext
    {
        public AppointmentDBContext(DbContextOptions<AppointmentDBContext> options) : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<TimeSlot> TimeSlots { get; set; }
    }
}
