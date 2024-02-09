using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproach.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext() 
        {
        }
        //public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        //{
        //}
        public EmployeeContext(DbContextOptions options)
        : base(options)
        {
        }

        public virtual DbSet<EmployeeModel> EmployeeModels { get; set; }

    }
}
