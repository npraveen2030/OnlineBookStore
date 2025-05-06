namespace BlazorApp.Models.Dtos
{
    public class WishlistDto
    {
        public int WishlistId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string? BookTitle { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
        public DateTime AddedOn { get; set; }
    }
}
