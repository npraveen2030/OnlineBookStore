using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Entities
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        public int CartId { get; set; }  // Primary key for Cart table

        [ForeignKey("User")]
        public int UserId { get; set; }  // Foreign key for User table

        [ForeignKey("Book")]
        public int BookId { get; set; }  // Foreign key for Book table

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int Quantity { get; set; }  // Quantity of the book in the cart

        public DateTime? DateAdded { get; set; } = DateTime.UtcNow;  // Timestamp when added to the cart

        public bool IsActive { get; set; } = true;  // Status of the item in the cart (active or removed)

        public DateTime? UpdatedDate { get; set; } = DateTime.UtcNow;  // Timestamp of the last update to the cart item

        // Navigation properties
        public virtual User User { get; set; }  // Navigation property to User
        public virtual Book Book { get; set; }  // Navigation property to Book
    }
}
