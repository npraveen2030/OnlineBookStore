using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages.User
{
    public partial class CartDetails
    {
        private List<Cart> cartItems = new List<Cart>();

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
                    .Include(c => c.Book)
                    .ToListAsync();
            }
            else
            {
                cartItems = new List<Cart>();
            }
            RecalculateTotal();

        }

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
