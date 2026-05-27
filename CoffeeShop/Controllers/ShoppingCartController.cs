using coffeeshop.Models.interfaces;
using CoffeeShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IShoppingCartRepository shoppingCartRepository;
        private IProductRepository productRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var items = shoppingCartRepository.GetAllShoppingCartItems();
            shoppingCartRepository.ShoppingCartItems = items;
            ViewBag.Total = shoppingCartRepository.GetShoppingCartTotal();
            return View(items);
        }

        public RedirectToActionResult AddToShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingCartRepository.AddToCart(product);
            }

            // Cập nhật cart count trong session
            var cartCount = shoppingCartRepository.GetAllShoppingCartItems().Sum(x => x.Qty);
            HttpContext.Session.SetInt32("CartCount", cartCount);

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pId)
        {
            var product = productRepository.GetAllProducts().FirstOrDefault(p => p.Id == pId);
            if (product != null)
            {
                shoppingCartRepository.RemoveFromCart(product);
            }

            
            var cartCount = shoppingCartRepository.GetAllShoppingCartItems().Sum(x => x.Qty);
            HttpContext.Session.SetInt32("CartCount", cartCount);

            return RedirectToAction("Index");
        }
    }
}