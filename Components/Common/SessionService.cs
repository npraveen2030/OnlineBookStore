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

        public void SetUser(int userId, string email, string role)
        {
            UserId = userId;
            UserEmail = email;
            Role = role;
            NotifyStateChanged();
        }

        public void Logout()
        {
            UserId = 0;
            UserEmail = null;
            Role = string.Empty;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
