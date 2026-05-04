using OnLineShop2026.Models;

namespace OnLineShop2026.Data
{
    public class UsersRepositoryMemory : IUsersRepository
    {
        private readonly List<User> _users = new List<User>() { new User("Anton", "Taraskin", "ant2006@gmail.com", "/images/userphoto.jpg"),
                                                                new User("Phantom", "User", "phant0m@gmail.com", "/images/userphoto.jpg")};
        public void Add(User user)
        {
            user.Id = Guid.NewGuid();
            _users.Add(user);
        }

        public List<User> GetAll() => _users;
        public User? TryGetById(Guid id) => _users.FirstOrDefault(x => x.Id == id);
    }
}
