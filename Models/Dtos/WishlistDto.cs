namespace BlazorApp.Models.Dtos
{
    public class WishlistDto
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? AuthorName { get; set; }
        public string? BookTypeName { get; set; }
        public decimal Price { get; set; }
        public DateTime AddedOn { get; set; }

        //public int? WishlistId { get; set; }  // Nullable in case the book is not in the wishlist
        public bool IsWishlisted { get; set; }
        public string ImageUrl { get; set; }
    }
}
