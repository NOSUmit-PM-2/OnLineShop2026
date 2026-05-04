using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;

namespace OnLineShop2026.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsersRepository _usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public IActionResult Index(Guid id)
        {
            var user = _usersRepository.TryGetById(id);
            if (user == null) return null;
            return View(user);
        }
    }
}
