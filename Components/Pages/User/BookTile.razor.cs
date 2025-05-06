namespace BlazorApp.Components.Pages.User
{
    public partial class BookTile
    {
        [Parameter] public string Title { get; set; }
        [Parameter] public string Author { get; set; }
        [Parameter] public string ImageUrl { get; set; }
        [Parameter] public decimal Price { get; set; }
        [Parameter] public EventCallback OnAddToCart { get; set; }
        [Parameter] public EventCallback OnRemoveFromWishlist { get; set; }

        private async Task AddToCart() => await OnAddToCart.InvokeAsync();
        private async Task RemoveFromWishlist() => await OnRemoveFromWishlist.InvokeAsync();
    }
}
