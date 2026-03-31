using OnLineShop2026.Models;
using System.Security.Cryptography;

namespace OnLineShop2026.Data
{
    public interface ICartRepository
    {
        List<Cart> GetAll();
        Cart? TryGetByUserId(int userId);
        void Increment(Guid productId);
        void Decrement(Guid productId);
    }
}