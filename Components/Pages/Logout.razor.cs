using BlazorApp.Components.Common;

namespace BlazorApp.Components.Pages
{
    public partial class Logout
    {
        [Inject]
        NavigationManager Nav { get; set; }
        private async Task HandleLogin()
        {
            Nav.NavigateTo("/login"); 

        }
    }
}
