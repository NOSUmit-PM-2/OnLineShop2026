using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UserRepositoryInMemory : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Чоко", "Пай", "4koPai@gmail.com"),
            new User("Ин", "Сулин", "Sylii@mail.com"),
            new User("Палпа", "Тин", "Anakin1lv@interglx.com")
        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? TryGetById(Guid id)
        {
            return users.FirstOrDefault(user => user.Id == id);
        }
    }
}