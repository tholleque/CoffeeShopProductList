using CoffeeShopMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopMVC.Controllers
{
    public class ProductsController : Controller
    {
        public readonly ProductsDbContext _productsDbContext;

        public ProductsController(ProductsDbContext productsDbContext)
        {
            _productsDbContext = productsDbContext;
        }

        public IActionResult Index()
        {
            List<Product> result = _productsDbContext.Products.ToList();
            return View(result);
        }
        public IActionResult Details(int id)
        {
            Product p = _productsDbContext.Products.FirstOrDefault(p => p.Id == id);
            return View(p);
        }
    }
}
