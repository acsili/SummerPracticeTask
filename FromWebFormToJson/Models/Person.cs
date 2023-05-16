using Microsoft.Build.Framework;

namespace FromWebFormToJson.Models
{
    public class Person
    {
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? MiddleName { get; set; }
        [Required]
        public DateOnly? BirthDate { get; set; }
    }
}
