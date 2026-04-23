using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        User user = new User()
        {
            Name = "Anton Taraskin",
            Email = "antnnn@gmail.com"
        };
        public IActionResult Index()
        {
            return View(user);
        }
    }
}
