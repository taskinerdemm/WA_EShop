using Microsoft.AspNetCore.Mvc;
using WA_EShop.Models.DB;

namespace WA_EShop.Controllers
{
    public class ProductListController : Controller
    {
        private EshopContext _context;
        public ProductListController(EshopContext context)
        {
            _context = context;
        }

        public ActionResult Category(int id)
        {
            return View(_context.Products.Where(c => c.CategoryId == id).ToList());
        }
        
    }
}
