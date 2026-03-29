using Microsoft.Extensions.Hosting;

namespace OnLineShop2026.Models
{
	public class User
	{

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string PhotoPath { get; set; }

		public User(string name, string email, string photoPath = "/images/basePhoto.jpg")
		{
			Name = name;
			Email = email;
			PhotoPath = photoPath;
		}

		public override string ToString()
		{
			return $"Имя - {Name}, почта - {Email}";
		}
	}
}
