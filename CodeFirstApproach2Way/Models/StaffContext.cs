using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach2Way.Models
{
    public class StaffContext:DbContext
    {
       
        public StaffContext(DbContextOptions<StaffContext> options):base(options) { }

        public DbSet<StaffModel> staffModels { get; set; }
    }
}
