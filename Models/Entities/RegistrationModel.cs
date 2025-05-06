using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Entities
{
    public class RegistrationModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required")]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 12 characters")]

        public string Password { get; set; } = "";

        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        //[Required]
        //public string Mobile { get; set; } = "";
        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string Mobile { get; set; } = "";

        public bool AcceptTerms { get; set; }
    }
}
