using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GenTechNepal.Web.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }

        public string? CompanyLogo { get; set; }

        [NotMapped]
        public IFormFile? Logo { get; set; }
    }
}
