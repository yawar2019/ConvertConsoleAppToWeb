using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach.Models
{
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }
        public string? EmpName { get; set; }

    }
}
