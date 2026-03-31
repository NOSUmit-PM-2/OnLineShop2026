using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class CartRepositoryInMemory : ICartRepository
    {
        private static List<Cart> carts = new List<Cart>() { new Cart() };


        public List<Cart> GetAll()
        { 
            return carts;
        }

        CartItem TryGetByProductId(Guid id)
        {
            return 
        }

        public void Increment(Guid productId)
        {
            Cart cart = TryGetByUserId(1);
            CartItem item = cart

            item.Amount += 1;
        }
        public void Decrement(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Cart? TryGetByUserId(int id)
        {
            //return carts.FirstOrDefault(cart => cart.Id == id);
            return carts[0];
        }
    }
}
