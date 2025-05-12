namespace BlazorApp.Components.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class CartService
    {
        private readonly List<CartItem> _cartItems = new();

        public event Action OnCartChanged;

        public void AddToCart(int bookId, int quantity)
        {
            var existingItem = _cartItems.FirstOrDefault(item => item.BookId == bookId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                _cartItems.Add(new CartItem
                {
                    BookId = bookId,
                    Quantity = quantity
                });
            }

            NotifyStateChanged();
        }

        public void RemoveFromCart(int bookId)
        {
            var cartItem = _cartItems.FirstOrDefault(item => item.BookId == bookId);
            if (cartItem != null)
            {
                _cartItems.Remove(cartItem);
            }

            NotifyStateChanged();
        }

        public int GetCartCount() => _cartItems.Sum(item => item.Quantity);

        private void NotifyStateChanged() => OnCartChanged?.Invoke();

        public List<CartItem> GetCartItems() => _cartItems;
    }

    public class CartItem
    {
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}