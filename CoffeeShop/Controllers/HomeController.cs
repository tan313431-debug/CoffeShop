using coffeeshop.Models.interfaces;
using CoffeeShop.Models.Interfaces;
using CoffeeShop.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository; 

        public HomeController(IProductRepository productRepository, IOrderRepository orderRepository) 
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository; 
        }

        public IActionResult Index()
        {
            var trendingProducts = _productRepository.GetTrendingProducts();
            return View(trendingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult MyOrders()
        {
            var userEmail = User.Identity?.Name;
            var orders = _orderRepository.GetOrdersByEmail(userEmail); 
            return View(orders);
        }
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(string name, string email, string message)
        {
            
            return RedirectToAction("Index");
        }
    }
}