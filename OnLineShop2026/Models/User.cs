namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid UserId { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserImage { get; set; }

        public User(string name, string surname, string password, string email, string userImage = "/images/vector.jpg")
        {
            UserId = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Password = password;
            Email = email;
            UserImage = userImage;
        }

    }
}

