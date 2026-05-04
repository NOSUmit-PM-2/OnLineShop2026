using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class AdminController : Controller
    {

       
        public IActionResult Index(int idUser)
        {
            return View();
        }
    }
}
