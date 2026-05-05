using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{ 
    public class UserRepository : IUserRepository
    {
        private static List<User> users = new List<User>()
        {
            new User("Иван","Иванов","ivan@mail.com","/images/user1.jpg"),

            new User("Анна","Петрова","anna@mail.com","/images/user2.jpg"),

            new User("Петр","Сидоров","petr@mail.com","/images/user3.jpg")

        };

        public List<User> GetAll()
        {
            return users;
        }

        public User? GetById(Guid userId)
        {
            return users.FirstOrDefault(x => x.UserId == userId);
        }
    }
}