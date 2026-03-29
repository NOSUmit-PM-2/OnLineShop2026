namespace OnLineShop2026.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; } 



        public User(string name, string surname, string email, string avatar = "/images/Avatar_Haley.png")
        {
            Id = Guid.NewGuid();          
            Name = name;
            Surname = surname;
            Email = email;
            Avatar = avatar;
        }

        public override string ToString()
        {
            return $"Имя - {Name}, Фамилия - {Surname}, почта - {Email}";

        }
    }
}
