using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        User user = new User("Иван Иванов", "email@email.com");
        private readonly ILogger<HomeController> _logger;
        public UserController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Guid id)
        {
            return View(user);
        }

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewData["pie"] = pie;
        //    return View();
        //}

        //public IActionResult Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    ViewBag.Pie = pie;
        //    return View();
        //}

        //public string Index()
        //{
        //    Product pie = new Product("Пирожок", "с котятами", 50);
        //    return pie.ToString();
        //}
    }
}
