using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp.Models.Entities
{
    [Table("Wishlist")]
    public class Wishlist
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime AddedOn { get; set; } = DateTime.UtcNow;

        // Navigation Properties (optional)
        public Book? Book { get; set; }
        public User? User { get; set; }
    }
}
