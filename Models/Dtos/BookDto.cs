using BlazorApp.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Dtos
{
    public class BookDto
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsActive { get; set; }
        public int? TypeId { get; set; }  // Foreign key
        public string? BookTypeName { get; set; }
        public BookTypeDto? Type { get; set; }  // Navigation property (optional)
    }
    public class BookTypeDto
    {
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        // Optional: Navigation property to related books
        public ICollection<Book>? Books { get; set; }
    }
}
