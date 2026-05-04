using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Interfaces;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        IUsersRepository usersRepository;
        public UserController(IUsersRepository usersRepository)
        {
            this.usersRepository = usersRepository;
        }
        public IActionResult Index(Guid id)
        {
            var user = usersRepository.TryGetById(id);
            if (user == null) return null;
            return View(user);
        }
    }
}
