using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class CartRepositoryInMemory : ICartRepository
    {
        private static List<Cart> carts = new List<Cart>()
        {
            new Cart()
        };

            
            public void Increment(Guid idProduct)
        {
            Cart cart = TryGetByUserId(int userId);
            CartItem item = cart.CartItems.FirstOrDefault(x => x.Product.Id == idProduct);
            item.Amount += 1;
        }

        public Cart? TryGetByUserId(int userId)
        {
            return carts[0];
        }
    }
}
