using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Helpers;
using OnLineShop2026.Models;
using OnlineShopp.DB;
using System.Diagnostics;
using System.Linq;

namespace OnLineShop2026.Controllers
{
    public class HomeController : Controller
    {
        IProductsDBRepository productRepository;

        public HomeController(IProductsDBRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Catalog()
        {
            List<ProductDB> listProducts = productRepository.GetAll();
            return View(Mapping.ToListProduct(listProducts));
        }

        public IActionResult Sort()
        {
            List<ProductDB> listProducts = productRepository.GetAll().OrderBy(i => i.Cost).ToList();
            return View("Catalog", Mapping.ToListProduct(listProducts));
        }
    }
}
