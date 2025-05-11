using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Components.Pages.User
{
    public partial class Register
    {
        //@inject IUserService UserService

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
                //await Context.Users.Add(newUser);
                //users = await UserService.GetUsersAsync();
                //newUser = new(); // Clear form

                Context.Users.Add(userObj);
                await Context.SaveChangesAsync();
                message = "User registered successfully!";


            }
            catch (Exception ex)
            {
                Message = $"{ex.Message}";
            }
        }
         
    }
}
