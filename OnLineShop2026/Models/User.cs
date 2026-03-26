namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Avatar { get; set; } 

        public User(string firstName, string lastName, string email, string avatar = "/images/avatar.png")
        {
            Id = Guid.NewGuid(); ;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Avatar = avatar;
        }

    }
}
