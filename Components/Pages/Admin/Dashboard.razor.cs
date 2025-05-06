using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;

namespace BlazorApp.Components.Pages.Admin
{
    public partial class Dashboard
    {
        [Inject] public SessionService sessionService { get; set; } = null!;
        public void m1()
        {

        }
        protected override async Task OnInitializedAsync()
        {
            if (sessionService != null && sessionService.UserEmail != null)
            {
                sessionService.UserEmail = sessionService.UserEmail;
                sessionService.Role = sessionService.Role;
                //sessionService.UserEmail = user.Email;
                //Session.FullName = user.FullName;
                sessionService.SetUser(sessionService.UserEmail, "");

            }
        }
    }
}
