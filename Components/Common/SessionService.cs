using BlazorApp.Models.Entities;

namespace BlazorApp.Components.Common
{
    public class SessionService
    {
        public int UserId { get; set; } = 0;
        public string? UserEmail { get; set; } 
        public string Role { get; set; }

        public bool IsLoggedIn => !string.IsNullOrEmpty(UserEmail);

        public event Action? OnChange;

        public void SetUser (string email, string fullName)
        {
            UserEmail = email;
            //FullName = fullName;
            NotifyStateChanged();
        }

        public void Logout()
        {
            UserEmail = null;
            //Email = null;
            //FullName = null;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
