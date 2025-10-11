using Microsoft.AspNetCore.Mvc;
using ServiceContract;

namespace UIProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("/product/list")]
        public IActionResult Products(string SearchType, string? SearchText)
        {
            var result = _productService.GetByFilter(SearchType, SearchText);
            return View(result);
        }

    }
}
