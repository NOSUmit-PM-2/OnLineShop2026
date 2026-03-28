using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;
namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        User user = new User("Давид", "Плиев", "example@gmail.com", "/images/user.png");
        public IActionResult Index()
        {
            return View(user);
        }
    }
}
