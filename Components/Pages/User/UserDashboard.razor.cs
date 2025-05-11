using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;
namespace BlazorApp.Components.Pages.User
{
    public partial class UserDashboard
    {
        private int userId = 2;

        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;
        public List<WishlistDto> lstWishListDto { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await GetWishList();
            await GetCartDetails();
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
        private async Task GetCartDetails()
        {

            cartItems = await Context.Carts
                .Where(c => c.UserId == UserId)
                .Include(c => c.Book)
                .Include(u => u.User)
                .Take(20)
                .ToListAsync();
            RecalculateTotal();

        }
        private async Task ToggleWishlistDto(WishlistDto wishlist)
        {
            Context.Wishlists.RemoveRange(Context.Wishlists.Where(b => b.WishlistId == wishlist.WishlistId));
            Context.SaveChangesAsync();

            // Remove from the in-memory list so UI updates
            lstWishListDto.RemoveAll(c => c.WishlistId == wishlist.WishlistId);
            //GetWishList();
        }

        private List<Cart> cartItems = new List<Cart>();

        private string searchText = string.Empty;
        private int? selectedTypeId = null;
        private List<BookDto> filteredBooks = new();
        private List<BookTypeDto> bookTypes = new();
        [Inject] public CartService CartService { get; set; } = null!;


        [Inject] public NavigationManager Nav { get; set; }

        private bool IsUpiSelected = false;
        private bool IsNetBankingSelected = false;
        private bool IsCreditCardSelected = false;
        private bool isCashOnDeliverySelected = false;
        [Inject] public SessionService sessionService { get; set; } = null!;

        public int UserId = 2;
        private decimal grandTotal;

        private void RecalculateTotal()
        {
            grandTotal = cartItems.Sum(item => item.Book.Price * item.Quantity);
            StateHasChanged();
        }

        private void PaymentChanged(ChangeEventArgs e)
        {
            IsUpiSelected = e.Value?.ToString() == "IsUpiSelected" ? true : false;
            IsNetBankingSelected = e.Value?.ToString() == "IsNetBankingSelected" ? true : false;
            IsCreditCardSelected = e.Value?.ToString() == "IsCreditCardSelected" ? true : false;
            isCashOnDeliverySelected = e.Value?.ToString() == "isCashOnDeliverySelected" ? true : false;
        }

        private async Task PaymentDone()
        {
            await Context.Carts
                    .Where(c => c.UserId == UserId)
                    .ForEachAsync(c => c.IsActive = false);

            await Context.SaveChangesAsync();

            Nav.NavigateTo("/paymentcompleted"); // redirect
        }
    }
}
