using backendCode.Models;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Data
{
    public class DoctorDbContext : DbContext
    {
        public DoctorDbContext(DbContextOptions<DoctorDbContext> options) : base(options)
        {

        }

        public DbSet<Doctor> Doctors { get; set; }
    }
}
