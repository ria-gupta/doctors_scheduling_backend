using backendCode.Models;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Data
{
    public class AppointementDbContext: DbContext
    {
        public AppointementDbContext(DbContextOptions<AppointementDbContext> options): base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
    }
}
