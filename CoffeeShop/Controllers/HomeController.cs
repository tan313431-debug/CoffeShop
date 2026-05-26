using coffeeshop.Models.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
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

    }
}