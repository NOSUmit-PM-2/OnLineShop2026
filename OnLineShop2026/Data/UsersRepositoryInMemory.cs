using OnLineShop2026.Interfaces;
using OnLineShop2026.Models;
using System.Data;
using System.Xml.Linq;

namespace OnLineShop2026.Data
{
    public class UsersRepositoryInMemory : IUsersRepository
    {
        private readonly List<User> _users = new List<User>() { new User("David", "Pliev", "david@gmail.com","/images/user.png"), new User("Alan", "Tsarakov", "alan@gmail.com", "/images/user.png") };
        public void Add(User user)
        {
            user.Id = Guid.NewGuid();
            _users.Add(user);
        }

        public List<User> GetAll() => _users;

        public User? TryGetById(Guid userId) => _users.FirstOrDefault(user => user.Id == userId);
        public User? TryGetByEmail(string email) => _users.FirstOrDefault(user => user.Email == email);
    }
}
