using Microsoft.AspNetCore.Mvc;
using WA_EShop.Models;
using WA_EShop.Models.DB;

namespace WA_EShop.Controllers
{
    public class HomeController : Controller
    {
        private EshopContext _context;

        public HomeController(EshopContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

    }
}
