using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
