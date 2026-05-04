using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;

namespace OnLineShop2026.Controllers
{
    public class AdminUserController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public AdminUserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        public IActionResult Index()
        {
            var users = _usersRepository.GetAll();
            return View(users);
        }       
    }
}
