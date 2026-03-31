using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            User user = new User(
                "Nazarov",
                "AmletixQ",
                "amletixq@best.com",
                "https://avatars.githubusercontent.com/u/98691645?v=4"
            );

            return View(user);
        }
    }
}
