using backendCode.Models;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Data
{
    public class SlotDbContext : DbContext
    {
        public SlotDbContext(DbContextOptions<SlotDbContext> options) : base(options)
        {

        }

        public DbSet<Slot> Slots { get; set; }
    }
}
