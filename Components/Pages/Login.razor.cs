using BlazorApp.Models.Dtos;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using BlazorApp.Models.Entities;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using BlazorApp.Components.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlazorApp.Components.Pages
{
    public partial class Login
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
        private string storedValue;
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
                //sessionService.SetUser(model.Email, "");
                sessionService.SetUser(sessionService.UserId, model.Email, sessionService.Role);
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
        private void ResetForm()
        {
            model = new LoginModel(); // Reset fields
        }
        public void Registeruser()
        {
            Nav.NavigateTo("/userregister"); // redirect

        }
    }

}