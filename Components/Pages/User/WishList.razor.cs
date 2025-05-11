using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
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
                                    //BookId = b.BookId,
                                    //Author = b.AuthorName,
                                    //Price = b.Price,

                                    WishlistId = w.WishlistId,
                                    BookId = b.BookId,
                                    Title = b.Title,
                                    AuthorName = b.AuthorName,
                                    Price = b.Price,
                                    //StockQuantity = b.StockQuantity,
                                    //PublishedDate = u.PublishedDate,
                                    ImageUrl = b.ImageUrl,
                                    //TypeId = b.TypeId,
                                    //BookTypeName = b.Type != null ? b.Type.TypeName : null,
                                    //IsActive = true,

                                })
                          .ToList();

        }

        private async Task ToggleWishlistDto(WishlistDto wishlist)
        {
            Context.Wishlists.RemoveRange(Context.Wishlists.Where(b => b.WishlistId == wishlist.WishlistId));
            Context.SaveChangesAsync();

            // Remove from the in-memory list so UI updates
            lstWishListDto.RemoveAll(c => c.WishlistId == wishlist.WishlistId);
            //GetWishList();
        }
    }
}
