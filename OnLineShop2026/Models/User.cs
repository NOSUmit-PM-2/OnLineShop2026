namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

        public User(string name, string lastName, string email, string photoUrl)
        {
            Id = new Guid();
            Name = name;
            LastName = lastName;
            Email = email;
            PhotoUrl = photoUrl;
        }
    }
}
