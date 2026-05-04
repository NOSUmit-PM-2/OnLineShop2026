using OnLineShop2026.Models;
using System.Data;

namespace OnLineShop2026.Interfaces
{
    public interface IUsersRepository
    {
        void Add(User user);
        User? TryGetByEmail(string email);
        List<User> GetAll();
        User? TryGetById(Guid userId);
    }
}
