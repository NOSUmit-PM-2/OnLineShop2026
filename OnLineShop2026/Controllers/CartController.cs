using Microsoft.AspNetCore.Mvc;
using OnLineShop2026.Data;
using OnLineShop2026.Models;

namespace OnLineShop2026.Controllers
{
    public class CartController : Controller
    {

        IProductRepository productRepository;
        ICartRepository cartRepository;

        public CartController(IProductRepository prodRep, ICartRepository cartRep)
        {
            this.productRepository = prodRep;
            this.cartRepository = cartRep;
        }

        public IActionResult Index(Guid id)
        {
            Product pr = productRepository.TryGetById(id);
            CartItem cartItem = new CartItem() 
            { 
                Product = pr,
                Amount = 1
            };
            var userCart = cartRepository.TryGetByUserId(12314);
            userCart.CartItems.Add(cartItem);

            return View(userCart);
        }

        public IActionResult Increment(Guid id)
        {
            var userCart = cartRepository.TryGetByUserId(12314);
            userCart.Increment(id);
            return View(userCart);
        }
    }
}
