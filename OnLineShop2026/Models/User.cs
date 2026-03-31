namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; }
        public string Fullname => $"{FirstName} {LastName}";

        public User()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
            Avatar = null;
        }


        public User(string firstName, string lastName, string email, string? avatar)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Avatar = avatar;
        }

        public override string ToString()
        {
            return $"User: {FirstName} {LastName}, Email: {Email}, Avatar: {(Avatar ?? "No Avatar")}";
        }

    }
}
