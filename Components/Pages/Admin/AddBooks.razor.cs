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

    public partial class AddBooks
    {
        [Inject] public AuthDbContext Context { get; set; } = null!;
        [Inject] public NavigationManager NavManager { get; set; } = null!;
        [Inject] public IJSRuntime JS { get; set; } = null!;

        private Book book = new Book { PublishedDate = DateTime.Today };
        private string message;
        public BookDto BookDtoForm { get; set; } = new();
        public List<BookDto> lstBooksDto { get; set; } = new();
        private Book? selectedBook;
        private List<BookTypeDto> bookTypes = new();

        protected override async Task OnInitializedAsync()
        {
            lstBooksDto = await Context.Books.Include(b => b.Type).Select(u => new BookDto
            {
                BookId = u.BookId,
                Title = u.Title,
                AuthorName = u.AuthorName,
                Price = u.Price,
                StockQuantity = u.StockQuantity,
                PublishedDate = u.PublishedDate,
                TypeId = u.BookId,
                BookTypeName = u.Type != null ? u.Type.TypeName : null,
                IsActive = true
            }).OrderByDescending(b => b.BookId)
                //.Skip((CurrentPage - 1) * PageSize)
                //.Take(PageSize)
                .ToListAsync();

            bookTypes = await Context.BookTypes.Select(u => new BookTypeDto
            {
                TypeId = u.TypeId,
                TypeName = u.TypeName 
            }).OrderByDescending(b => b.TypeId).ToListAsync();
        }
 
        private async Task SaveBook()
        {
            Context.Books.Add(book);
            await Context.SaveChangesAsync();
            message = "Book saved successfully!";

            book = new Book { PublishedDate = DateTime.Today };
            lstBooksDto = await Context.Books.Select(u => new BookDto
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

        private void EditBook(BookDto book)
        {
            // Create a copy so changes aren't reflected until save
            selectedBook = new Book
            {
                BookId = book.BookId,
                Title = book.Title,
                AuthorName = book.AuthorName,
                Price = book.Price,
                StockQuantity = book.StockQuantity,
                PublishedDate = book.PublishedDate,
                TypeId = book.TypeId,
                //BookTypeName = u.Type != null ? u.Type.TypeName : null,
                IsActive = true
            };
        }
        private void CancelEdit()
        {
            selectedBook = null;
        }
        private async Task ConfirmDelete(int bookId)
        {
            bool confirmed = await JS.InvokeAsync<bool>("confirm", "Are you sure you want to delete this book?");
            if (confirmed)
            {
                await DeleteBook(bookId);
            }
        }

        private async Task DeleteBook(int bookId)
        {
            var book = await Context.Books.FindAsync(bookId);
            if (book != null)
            {
                Context.Books.Remove(book);
                await Context.SaveChangesAsync();

                // Refresh list
                lstBooksDto = await Context.Books.Select(u => new BookDto
                {
                    BookId = u.BookId,
                    Title = u.Title,
                    AuthorName = u.AuthorName,
                    Price = u.Price,
                    StockQuantity = u.StockQuantity,
                    PublishedDate = u.PublishedDate,
                    TypeId = u.BookId,
                    IsActive = true
                }).OrderByDescending(b => b.BookId)
               .ToListAsync();

                // Clear edit if it was the deleted one
                if (selectedBook?.BookId == bookId)
                {
                    selectedBook = null;
                }
            }
        }

        private async Task UpdateBook()
        {
            if (selectedBook != null)
            {
                var bookInDb = await Context.Books.FindAsync(selectedBook.BookId);
                if (bookInDb != null)
                {
                    bookInDb.Title = selectedBook.Title;
                    bookInDb.AuthorName = selectedBook.AuthorName;
                    bookInDb.Price = selectedBook.Price;
                    bookInDb.StockQuantity = selectedBook.StockQuantity;
                    bookInDb.PublishedDate = selectedBook.PublishedDate;
                    bookInDb.TypeId = selectedBook.TypeId;

                    await Context.SaveChangesAsync();

                    // Refresh the list
                    lstBooksDto = await Context.Books.Select(u => new BookDto
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

                    selectedBook = null;
                }
            }

        }
    }
}
