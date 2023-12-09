using System.ComponentModel.DataAnnotations;

namespace GenTechNepal.API.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        public string? Username { get; set; }

        public string? FullName { get; set; }

        public string? EmailAddress { get; set; }

        public string? ProfilePicture { get; set; }

        public string? ContactNumber { get; set; }

        public int CompanyId { get; set; }
    }
}
