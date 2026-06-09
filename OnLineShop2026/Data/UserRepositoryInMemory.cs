using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Первый", "Поперечный", "123456", "first@mail.ru"),
            new User("Второй", "Вдольный","1234567", "second@mail.ru"),
            new User("Третий", "Треугольный","12345678", "third@mail.ru")
        };

        public List<User> GetAll()
        { 
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.UserId == id);
        }
    }
}
