using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages.User
{
    public partial class CartDetails
    {
        private List<CartDto> cartItems = new List<CartDto>();

        private string searchText = string.Empty;
        private int? selectedTypeId = null;
        private List<BookDto> filteredBooks = new();
        private List<BookTypeDto> bookTypes = new();
        [Inject] public CartService CartService { get; set; } = null!;

        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;

        [Inject] public NavigationManager Nav { get; set; }

        private bool IsUpiSelected = false;
        private bool IsNetBankingSelected = false;
        private bool IsCreditCardSelected = false;
        private bool isCashOnDeliverySelected = false;
        [Inject] public SessionService sessionService { get; set; } = null!;

        public int UserId = 2;
        private decimal grandTotal;

        protected override async Task OnInitializedAsync()
        {
            if (UserId > 0)
            {
                cartItems = await Context.Carts
                    .Where(c => c.UserId == UserId && c.IsActive)
                    .Join(Context.Books,
                                w => w.BookId,
                                b => b.BookId,
                                (w, b) => new CartDto
                                {
                                    ImageUrl = b.ImageUrl,

                                    Title = b.Title,
                                    Price = b.Price,
                                    StockQuantity = b.StockQuantity
                                    //BookId = b.BookId,
                                    //Author = b.AuthorName,
                                    //Price = b.Price,

                                    ////WishlistId = w.WishlistId,
                                    //BookId = b.BookId,
                                    //Title = b.Title,
                                    //AuthorName = b.AuthorName,
                                    //StockQuantity = b.StockQuantity,
                                    //PublishedDate = u.PublishedDate,
                                    //TypeId = b.TypeId,
                                    //BookTypeName = b.Type != null ? b.Type.TypeName : null,
                                    //IsActive = true,

                                })
                    //.Include(c => c.Book)
                    .ToListAsync();
            }
            else
            {
                cartItems = new List<CartDto>();
            }
            RecalculateTotal();

        }

        private void RecalculateTotal()
        {
            if(cartItems != null && cartItems.Count > 0)
            {
                grandTotal = cartItems.Sum(item => item.Price * item.StockQuantity);

            }
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
