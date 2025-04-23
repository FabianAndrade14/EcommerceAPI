using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Models
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
