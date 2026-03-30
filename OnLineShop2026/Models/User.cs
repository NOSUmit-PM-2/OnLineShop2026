using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineShop2026.Models
{
    internal class User
    {
        public User(Guid id, string name, string email, string photoUrl = "/images/raccoon.jpg")
        {
            Id = id;
            Name = name;
            Email = email;
            PathImage = photoUrl;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PathImage { get; set; }
    }
}
