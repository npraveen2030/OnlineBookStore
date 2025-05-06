using BlazorApp.Models.Entities;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using BlazorApp.Models.Entities;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;
using System;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using BlazorApp.Models.Entities;
using BlazorApp.Models.Dtos;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;
using System;



namespace BlazorApp.Components.Pages.Admin
{
    public partial class SearchBooks
    {
        private string searchText = string.Empty;
        private int? selectedTypeId = null;
        private List<BookDto> filteredBooks = new();
        private List<BookTypeDto> bookTypes = new();
        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;

        private Book book = new Book { PublishedDate = DateTime.Today };
        private string message;
        public BookDto BookDtoForm { get; set; } = new();
        public List<BookDto> lstBooksDto { get; set; } = new();
        private Book? selectedBook;
        //private List<BookTypeDto> bookTypes = new();
        protected override async Task OnInitializedAsync()
        {
            bookTypes = await Context.BookTypes.Select(u => new BookTypeDto
            {
                TypeId = u.TypeId,
                TypeName = u.TypeName
            }).OrderByDescending(b => b.TypeId).ToListAsync();
            //bookTypes = await DbContext.BookTypes.ToListAsync();
            await SearchBooksGrid(); // load all books initially
        }

        private async Task SearchBooksGrid()
        {
            filteredBooks = await Context.Books.Include(b => b.Type)
            .Where(b =>
                (string.IsNullOrEmpty(searchText) ||
                 b.Title.Contains(searchText) ||
                 b.AuthorName.Contains(searchText)) ||
                   (  b.Type.TypeName.Contains(searchText))
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
                TypeId = u.TypeId,
                BookTypeName = u.Type != null ? u.Type.TypeName : null,
                IsActive = true
            }).OrderByDescending(b => b.BookId)
                .ToListAsync();
        }
    }
}
