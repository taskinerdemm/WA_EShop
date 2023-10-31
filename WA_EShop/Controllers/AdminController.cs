using Microsoft.AspNetCore.Mvc;

namespace WA_EShop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
