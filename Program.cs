using BlazorApp.Components;
using BlazorApp.Components.Common;
using Blazored.LocalStorage;
namespace BlazorApp
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddDbContext<AuthDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<SessionService>();
            //builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddScoped<CartService>();
            builder.Services.AddServerSideBlazor()
                .AddCircuitOptions(options => 
                {
                    options.DetailedErrors = true;
                });
            builder.Services.AddSingleton<AuthService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            //app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
