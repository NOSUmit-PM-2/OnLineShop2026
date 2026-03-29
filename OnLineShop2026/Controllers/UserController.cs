using Microsoft.AspNetCore.Mvc;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            
            var user = new Models.User("Иван", "Иванов", "ivan.ivanov@example.com");
            return View(user);
        }
    }
}
