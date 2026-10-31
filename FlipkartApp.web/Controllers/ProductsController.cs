using FlipkartApp.Business;
using Microsoft.AspNetCore.Mvc;

namespace Flipkartapp.web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _service = new ProductService();

        public IActionResult Index()
        {
            var products = _service.GetAllProducts();
            return View(products);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(FlipkartApp.Data.Product product)
        {
            _service.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
