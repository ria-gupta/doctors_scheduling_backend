using backendCode.Models;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Data
{
    public class AppointmentDbContext: DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options): base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
