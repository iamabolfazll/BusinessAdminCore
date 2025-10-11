using Microsoft.AspNetCore.Mvc;
using ServiceContract;

namespace UIProject.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IProductService _productService;
        //public HomeController(IProductService productService)
        //{ 
        //    _productService = productService;
        //}
        [Route("/dashboard")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("/product")]
        //public IActionResult Product()
        //{
        //    var result = _productService.GetAll();
        //    return View(result);
        //}

    }
}
