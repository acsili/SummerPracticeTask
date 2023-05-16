//using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace FromWebFormToJson.Models
{
    public class Person
    {
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string? LastName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string? FirstName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 1)]
        public string? MiddleName { get; set; }
        [Required]
        public DateOnly? BirthDate { get; set; }
    }
}
