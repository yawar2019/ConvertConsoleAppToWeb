using System.ComponentModel.DataAnnotations;

namespace CodeFirstApproach2Way.Models
{
    public class StaffModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
