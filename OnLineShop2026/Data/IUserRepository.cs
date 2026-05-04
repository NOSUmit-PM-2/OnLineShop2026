using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public interface IUserRepository
    {
            public User? TryGetById(int id);
            public User? TryGetByEmail(string email);
    }
}
