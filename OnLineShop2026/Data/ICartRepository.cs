using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface ICartRepository
    {
        List<Cart> GetAll();
        Cart? TryGetByUserId(int userId);
    }
}