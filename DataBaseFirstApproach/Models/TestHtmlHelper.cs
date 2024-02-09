using System.ComponentModel.DataAnnotations;

namespace DataBaseFirstApproach.Models
{
    public class TestHtmlHelper
    {
        [EmailAddress]
        public string? CompanyEmail { get; set; }
        [Required]
        public string Password { get; set; }
        public string EnumCountry { get; set; }
        public string Agreed { get; set; }
      
        [MinLength(5)]
        [MaxLength(1024)]

        public string Description { get; set; }
    }
}
