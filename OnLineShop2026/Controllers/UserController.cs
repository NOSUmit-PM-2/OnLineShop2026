using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            var user = new User("Соми", "Соя", "SomiSoya@gmail.com");
            return View(user);
        }
    }
}
