namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid UserId { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string UserImage { get; set; }
        
        public User(string name, string surname, string email, string userImage = "/images/pumpkin.png")
        {
            UserId = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            UserImage = userImage;
        }

    }
}
