using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages.User
{
    public partial class WishList
    {
        private int userId = 2;

        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;
        public List<WishlistDto> lstWishListDto { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await GetWishList();
        }

        private async Task GetWishList()
        {

            lstWishListDto = Context.Wishlists
                          .Where(w => w.UserId == userId)
                          .Join(Context.Books,
                                w => w.BookId,
                                b => b.BookId,
                                (w, b) => new WishlistDto
                                {
                                    WishlistId = w.WishlistId,
                                    BookId = b.BookId,
                                    Title = b.Title,
                                    AuthorName = b.AuthorName,
                                    Price = b.Price,
                                    ImageUrl = b.ImageUrl,

                                })
                          .ToList();

        }

        private async Task ToggleWishlistDto(WishlistDto wishlist)
        {
            Context.Wishlists.RemoveRange(Context.Wishlists.Where(b => b.WishlistId == wishlist.WishlistId));
            Context.SaveChangesAsync();

            lstWishListDto.RemoveAll(c => c.WishlistId == wishlist.WishlistId);
        }
    }
}
