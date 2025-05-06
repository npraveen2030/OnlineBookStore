using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Dtos
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = "";
        public int? UserType { get; set; }      }
}
