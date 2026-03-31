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

        public Cart? TryGetByUserId(int id)
        {
            //return carts.FirstOrDefault(cart => cart.Id == id);
            return carts[0];
        }
    }
}
