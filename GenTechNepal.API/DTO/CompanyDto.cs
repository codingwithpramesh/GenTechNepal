using System.ComponentModel.DataAnnotations;

namespace GenTechNepal.API.DTO
{
    public class CompanyDto
    {

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }

        public string? CompanyLogo { get; set; }
    }
}
