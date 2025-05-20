using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models.Entities
{
    [Table("Books")]
    public class Book
    {
        public int BookId { get; set; }  // Identity / Primary Key
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsActive { get; set; }
        public int? TypeId { get; set; }  // Foreign key
        public BookType? Type { get; set; }  // Navigation property (optional)
    }
    [Table("BookTypes")]
    public class BookType
    {
        [Key]
        public int TypeId { get; set; }

        public string TypeName { get; set; }

        // Optional: Navigation property to related books
        public ICollection<Book>? Books { get; set; }
    }
}
