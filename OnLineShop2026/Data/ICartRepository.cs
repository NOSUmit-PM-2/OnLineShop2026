using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface ICartRepository
    {
        Cart? TryGetByUserId(int userId);
        void Increment(Guid idProduct);
    }
}