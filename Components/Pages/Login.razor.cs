using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages
{
    public partial class Login
    {
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
        private string storedValue;
        [Inject] public SessionService sessionService { get; set; } = null!;

        private async Task HandleLogin()
        {
            try
            {
                var userObj = await Context.Users
                    .Where(u => u.Username == model.Email && u.Password == model.Password)
                    .FirstOrDefaultAsync();
                if (userObj != null)
                {
                    sessionService.UserId = userObj.UserId;
                    sessionService.UserEmail = model.Email;
                    sessionService.Role = model.UserType == 1 ? "Admin" : "NonAdmin";
                    if (userObj.UserType == 1)
                        Nav.NavigateTo("/admindashboardcomp");
                    else
                        Nav.NavigateTo("/clientdashboard");  
                }
                else
                {
                    errorMessage = "Invalid email or password.";
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void ResetForm()
        {
            model = new LoginModel();
        }
        public void Registeruser()
        {
            Nav.NavigateTo("/userregister");

        }
    }

}