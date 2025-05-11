using BlazorApp.Components.Common;

namespace BlazorApp.Components.Layout
{
    public partial class MainLayout
    {
        private int cartCount;
        [Inject] public SessionService sessionService { get; set; } = null!;

        [Inject]
        public CartService CartService { get; set; } = null!;
        protected override void OnInitialized()
        {
            sessionService.OnChange += StateHasChanged;
            //sessionService.OnChange += StateHasChanged;// Get the initial cart count
            cartCount = CartService.GetCartCount();

            // Subscribe to the cart change event
            CartService.OnCartChanged += HandleCartChanged;


        }
        private void HandleCartChanged()
        {
            // Update the cart count whenever the cart changes
            cartCount = CartService.GetCartCount();
            StateHasChanged(); // Triggers a re-render
        }


        public void Dispose()
        {
            CartService.OnCartChanged -= HandleCartChanged;

            sessionService.OnChange -= StateHasChanged;
        }
    }
}
