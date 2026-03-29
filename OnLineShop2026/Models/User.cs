namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string AvatarImage { get; set; }

        public User(string name, string surname, string email, string avatarImage)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Email = email;
            AvatarImage = avatarImage;
        }

    }
}
