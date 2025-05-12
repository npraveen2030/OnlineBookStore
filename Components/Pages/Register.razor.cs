using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;

namespace BlazorApp.Components.Pages
{
    public partial class Register
    {
        [Inject] public AuthDbContext Context { get; set; } = null!;
        private RegistrationModel registrationModel = new();
        protected string Message = string.Empty;
        private List<UserDto> users = new();
        private UserDto newUser = new();
        private readonly string _filePath = Path.Combine("wwwroot", "UserData.json");
        private string message;

        protected async Task HandleRegister()
        {
            try
            {
                var userObj = new BlazorApp.Models.Entities.User
                {
                    Username = registrationModel.Email,
                    Password = registrationModel.Password,
                    Firstname = registrationModel.FirstName,
                    Lastname = registrationModel.LastName,
                    Address = registrationModel.Address,
                    Phone = registrationModel.Mobile,
                    MailId = registrationModel.Email,
                    UserType = 2
                };

                Context.Users.Add(userObj);
                await Context.SaveChangesAsync();
                message = "User registered successfully!";
                registrationModel = new RegistrationModel();
            }
            catch (Exception ex)
            {
                Message = $"{ex.Message}";
            }
        }

    }
}
