using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Entities
{
    public class RegistrationModel
    {
        [Required]
        public string Email { get; set; } = "";

        [Required]
        public string Password { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        [Required]
        public string Mobile { get; set; } = "";

        public bool AcceptTerms { get; set; }
    }
}
