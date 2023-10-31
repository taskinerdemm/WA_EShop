using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using WA_EShop.Models;
using WA_EShop.Models.DB;

namespace WA_EShop.Controllers
{
    public class ProductController : Controller
    {
        private EshopContext _context;

        public ProductController(EshopContext context)
        {
            _context = context;
        }

        public IActionResult Index(int pg=1)
        {
            List<Products> products = _context.Products.ToList();

            //return View(_context.Products.ToList());

            const int pageSize = 9;
            if (pg < 1)
                pg = 1;
            int recsCount = products.Count();

            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = products.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;

            //return View(products);
            return View(data);
        }

        EshopContext c = new EshopContext();
        public ActionResult GetAllProducts(string p)
        {
            var values = from x in c.Products select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(y => y.ProductName.Contains(p));
            }
            //var values = c.Products.ToList();
            return View(values.ToList()) ;
        }

        public IActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.ProductId == id).FirstOrDefault());
        }
    }
}
