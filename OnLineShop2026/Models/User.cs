namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }

        public User(string nameSurname, string email, string avatar = "/images/default_avatar.jpg")
        {
            Id = Guid.NewGuid();
            NameSurname = nameSurname;
            Email = email;
            Avatar = avatar;
        }
    }
}
