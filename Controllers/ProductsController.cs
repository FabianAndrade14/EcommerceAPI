using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
