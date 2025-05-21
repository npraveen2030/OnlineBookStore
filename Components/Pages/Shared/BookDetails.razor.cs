using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using static System.Reflection.Metadata.BlobBuilder;
using BlazorApp.Components.Common;
using BlazorApp.Models.Dtos;
using BlazorApp.Models.Entities;
using Microsoft.JSInterop;

namespace BlazorApp.Components.Pages.Shared
{
    public partial class BookDetails
    {
        private BookDto book;
        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;
        protected override async Task OnInitializedAsync()
        {
            try
            {
                var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
                var query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(uri.Query);

                if (query.TryGetValue("bookId", out var bookIdString) &&
                    int.TryParse(bookIdString, out int bookId))
                {
                    var  bookss = await Context.Books
                            .Where(x => x.BookId == bookId).Select(u => new BookDto()
                            {
                                Title = u.Title,
                                ImageUrl = u.ImageUrl,
                                ContentImage = u.ContentImage,
                                AuthorName = u.AuthorName,
                                Description = u.Description ?? "",
                                Price = u.Price,
                                BookTypeName = u.Type != null ? u.Type.TypeName : null,

                                StockQuantity = u.StockQuantity,
                                PublishedDate = u.PublishedDate,
                                TypeId = u.TypeId,
                                IsActive = true
                            }).FirstOrDefaultAsync();

                    book = bookss;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
