namespace BlazorApp.Components.Common
{
    public class AuthService
    {
        public bool IsLoggedIn { get; private set; } = false;

        public Task<bool> LoginAsync(string username, string password)
        {
            // Dummy login check
            if (username == "admin" && password == "password")
            {
                IsLoggedIn = true;
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }

        public void Logout() => IsLoggedIn = false;
    }

}
