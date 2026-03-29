using Microsoft.AspNetCore.Mvc;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            // Не передаём путь к аватару — будет использован дефолт из модели
            var user = new Models.User("Иван", "Иванов", "ivan.ivanov@example.com");
            return View(user);
        }

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Profile));
        }
    }
}
