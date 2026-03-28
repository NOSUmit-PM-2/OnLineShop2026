namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string Name { get; }
        public string SecondName { get; }
        public string Email { get; }
        public string PathImage { get; }

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
