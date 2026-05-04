namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Email { get; set; }
        public string PathImage { get; set; }

        public User(string name, string secondName, string email, string pathImage)
        {
            Id = Guid.NewGuid();
            Name = name;
            SecondName = secondName;
            PathImage = pathImage;
            Email = email;
        }
    }
}
