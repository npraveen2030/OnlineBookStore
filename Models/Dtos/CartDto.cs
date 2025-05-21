using BlazorApp.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models.Dtos
{
    public class CartDto
    {
        public int CartId { get; set; }  // Primary key for Cart table

        public int UserId { get; set; }  // Foreign key for User table

        public int BookId { get; set; }  // Foreign key for Book table

        public int Quantity { get; set; }  // Quantity of the book in the cart
        public int StockQuantity { get; set; }  // Quantity of the book in the cart
        public decimal Price { get; set; }  // Quantity of the book in the cart
        public string ImageUrl { get; set; }  // Quantity of the book in the cart
        public string Title { get; set; }  // Quantity of the book in the cart

        public DateTime? DateAdded { get; set; } = DateTime.UtcNow;  // Timestamp when added to the cart

        public bool IsActive { get; set; } = true;  // Status of the item in the cart (active or removed)

        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;  // Timestamp of the last update to the cart item

        public virtual User User { get; set; }  // Navigation property to User
        public virtual Book Book { get; set; }  // Navigation property to Book
    }
}
