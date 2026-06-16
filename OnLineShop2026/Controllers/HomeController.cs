using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Helpers;
using OnLineShop2026.Models;
using OnlineShopp.DB;

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

        public IActionResult Catalog(string searchString)
        {
            List<ProductDB> listProducts = productRepository.GetAll();
            var products = Mapping.ToListProduct(listProducts);

            if (!string.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString)).ToList();
            }

            ViewBag.SearchString = searchString;
            return View(products);
        }

    }
}
