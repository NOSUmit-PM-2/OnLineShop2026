namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string AvatarImage { get; set; } 

        public string FullName => $"{Name} {Surname}";

        public User(string name, string surname, string email, string avatarImage = "/images/default-avatar.jpg")
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            AvatarImage = avatarImage;
        }

        

    }
}
