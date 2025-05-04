using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Components.Pages
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

        protected async Task HandleRegister()
        {




            try
            {

                var userObj = new User
                {
                    Username = "userDto.Username",
                    Password = "default123", // Or encrypt properly
                    Firstname = "userDto.Firstname",
                    Lastname = "userDto.Lastname",
                    Address = " userDto.Address",
                    Phone = "1111",
                    MailId = "userDto.MailId",
                    UserType = 2
                };
                //await Context.Users.Add(newUser);
                //users = await UserService.GetUsersAsync();
                //newUser = new(); // Clear form

                Context.Users.Add(userObj);
                await Context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                Message = $"{ex.Message}";
            }
        }

        protected async Task HandleRegister1()
        {




            try
            {

                var userObj = new User
                {
                    Username = "userDto.Username",
                    Password = "default123", // Or encrypt properly
                    Firstname = "userDto.Firstname",
                    Lastname = "userDto.Lastname",
                    Address = " userDto.Address",
                    Phone = "1111",
                    MailId = "userDto.MailId",
                    UserType = 2
                };
                //await Context.Users.Add(newUser);
                //users = await UserService.GetUsersAsync();
                //newUser = new(); // Clear form

                Context.Users.Add(userObj);
                await Context.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                Message = $"{ex.Message}";
            }
        }
    }
}
