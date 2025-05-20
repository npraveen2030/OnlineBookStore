using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages.User
{ 
    public partial class SearchBooks
    {
        private int quantity = 1;
        private int UserId = 2;
        private string searchText = string.Empty;
        private int? selectedTypeId = null;
        private List<BookDto> filteredBooks = new();
        private List<BookTypeDto> bookTypes = new();
        private int cartCount = 0;

        [Inject] public SessionService sessionService { get; set; } = null!;

        [Inject] public NavigationManager Nav { get; set; }
        [Inject] public CartService CartService{ get; set; } = null!;

        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;

        public BookDto BookDtoForm { get; set; } = new();
        public List<BookDto> lstBooksDto { get; set; } = new();
        private List<Book> books = new();

        private void ToggleWishlistDto(BookDto book)
        {
            book.WishlistInfo.IsWishlisted = !book.WishlistInfo.IsWishlisted;

            if (book.WishlistInfo.IsWishlisted)
            {
                var wishlistItem = new Wishlist
                {
                    UserId = UserId,
                    BookId = book.BookId,
                    AddedOn = DateTime.UtcNow
                };

                Context.Wishlists.Add(wishlistItem);
                Context.SaveChangesAsync();
            }
            else
            {
                Context.Wishlists.RemoveRange(Context.Wishlists.Where(b => b.WishlistId == book.WishlistInfo.WishlistId));
                Context.SaveChangesAsync();
            }
        }

        protected override async Task OnInitializedAsync()
        {
            bookTypes = await Context.BookTypes.Select(u => new BookTypeDto
            {
                TypeId = u.TypeId,
                TypeName = u.TypeName
            }).OrderByDescending(b => b.TypeId).ToListAsync();
            await SearchBooksGrid();
        }

        private async Task SearchBooksGrid()
        {
            filteredBooks = await Context.Books.Include(b => b.Type)
            .Where(b =>
                (string.IsNullOrEmpty(searchText) ||
                 b.Title.Contains(searchText) ||
                 b.AuthorName.Contains(searchText)) ||
                   (b.Type.TypeName.Contains(searchText))
                &&
                (!selectedTypeId.HasValue || b.TypeId == selectedTypeId.Value
                || b.Type.TypeName.Contains(searchText))
                )
            .Select(u => new BookDto
            {
                BookId = u.BookId,
                Title = u.Title,
                AuthorName = u.AuthorName,
                Price = u.Price,
                StockQuantity = u.StockQuantity,
                PublishedDate = u.PublishedDate,
                ImageUrl = u.ImageUrl ?? "",
                TypeId = u.TypeId,
                BookTypeName = u.Type != null ? u.Type.TypeName : null,
                IsActive = true,
                WishlistInfo = new WishlistDto
                {
                    WishlistId = Context.Wishlists
                    .Where(w => w.BookId == u.BookId && w.UserId == sessionService.UserId)
                    .Select(w => w.WishlistId)
                    .FirstOrDefault(),
                    IsWishlisted = Context.Wishlists
                    .Any(w => w.BookId == u.BookId && w.UserId == sessionService.UserId)
                }
            }).OrderByDescending(b => b.BookId)
                .ToListAsync();
        }

        public async Task AddToWishlist(BookDto book)
        { 
            var exists = await Context.Wishlists
            .AnyAsync(w => w.UserId == sessionService.UserId && w.BookId == book.BookId);

            if (!exists)
            {
                var wishlist = new Wishlist
                {
                    UserId = UserId,
                    BookId = book.BookId
                };

                Context.Wishlists.Add(wishlist);
                await Context.SaveChangesAsync();
            }
        }

        public async Task AddToCart(BookDto book)
        { 
            var cartItem = new Cart
            {
                UserId = UserId,
                BookId = book.BookId,
                Quantity = quantity,
                DateAdded = DateTime.UtcNow,
                UpdatedDate = DateTime.UtcNow
            };

            Context.Carts.Add(cartItem);
            Context.SaveChangesAsync();

            cartCount++;
            CartService.AddToCart(book.BookId, quantity);
        }

        private void NavigateToCart()
        {
            Nav.NavigateTo("/cart");
        }
        private async Task OpenBookDetails(int bookId)
        {
            var url = $"/bookdetails?bookId={bookId}";
            await JS.InvokeVoidAsync("open", url, "_blank");
        }
    }
}
