namespace OnLineShop2026.Models
{
    public class User
    {
        private Guid _id;
        public string Name { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; } = "";

    }
}
