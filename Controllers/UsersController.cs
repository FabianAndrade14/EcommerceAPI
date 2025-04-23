using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
