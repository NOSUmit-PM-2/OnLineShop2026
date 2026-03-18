namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }

        public User(string firstName, string lastName, string email, string imagePath)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            ImagePath = imagePath;
            Id = Guid.NewGuid();
        }
    }
}
