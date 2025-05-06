using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages
{
    public partial class Authentication : ComponentBase
    {
        public string activeTab = "SignIn";

        public void SetActiveTab(string tab)
        {
            activeTab = tab;
        }
        [Inject]
        NavigationManager Nav { get; set; }
        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;

        private Book book = new Book { PublishedDate = DateTime.Today };
        private string message;
        public BookDto BookDtoForm { get; set; } = new();
        public List<BookDto> lstBooksDto { get; set; } = new();
        private Book? selectedBook;
        private List<BookTypeDto> bookTypes = new();
        private LoginModel model = new();
        private string? errorMessage;
        [Inject] public SessionService sessionService { get; set; } = null!;

        private async Task HandleLogin()
        {
            //var user = await AuthService.ValidateUserAsync(model.Email, model.Password);
            var userObj = await Context.Users
                .Where(u => u.Username == model.Email && u.Password == model.Password)
                //.Select(a=>a.Password)
                .FirstOrDefaultAsync();
            if (userObj != null)
            {
                // Set session-like values
                sessionService.UserId = userObj.UserId;
                sessionService.UserEmail = model.Email;
                sessionService.Role = model.UserType == 1 ? "Admin" : "NonAdmin";
                //sessionService.UserEmail = user.Email;
                //Session.FullName = user.FullName;
                sessionService.SetUser(model.Email, "");
                //Nav.NavigateTo("/dashboard",true); // redirect

                if (userObj.UserType == 1)
                    Nav.NavigateTo("/admindashboard");
                else
                    Nav.NavigateTo("/clientdashboard"); // redirect
            }
            else
            {
                errorMessage = "Invalid email or password.";
            }

        }

        public void Registeruser()
        {
            Nav.NavigateTo("/register"); // redirect

        }
    }

}