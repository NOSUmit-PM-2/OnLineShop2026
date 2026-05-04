using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepository : IUserRepository
    {
        public User? TryGetById(int userId)
        {
            return new User
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                Avatar = "https://example.com/avatar.jpg",
                Email = "john.doe@example.com"
            };
        }

        public User? TryGetByEmail(string email)
        {
            return new User
            {
                Id = new Guid(),
                FirstName = "John",
                LastName = "Doe",
                Avatar = "https://example.com/avatar.jpg",
                Email = email
            };
        }
    }
}
