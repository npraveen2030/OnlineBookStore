using BlazorApp.Components.Common;

namespace BlazorApp.Components.Layout
{
    public partial class MainLayout
    {
        [Inject] public SessionService sessionService { get; set; } = null!;
        protected override void OnInitialized()
        {
              sessionService.OnChange += StateHasChanged;
            //sessionService.OnChange += StateHasChanged;
        }

        public void Dispose()
        {
            sessionService.OnChange -= StateHasChanged;
        }
    }
}
