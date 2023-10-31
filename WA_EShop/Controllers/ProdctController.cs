using Microsoft.AspNetCore.Mvc;
using WA_EShop.Models.DB;

namespace WA_EShop.Controllers
{
    public class ProdctController : Controller
    {
        EshopContext eshopContext;
        IWebHostEnvironment hostingenvironment;
        public ProdctController(EshopContext es, IWebHostEnvironment he)
        {
            eshopContext = es;
            hostingenvironment = he;
        }
            
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult addproduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addproduct(ProductViewModels product1)
        {
            string filename = "";
            if (product1.Photo!=null)
            {
                string uploadfolder = Path.Combine(hostingenvironment.WebRootPath, "Images");
                filename = Guid.NewGuid().ToString() + "_" + product1.Photo.FileName;
                string filepath = Path.Combine(uploadfolder, filename);
                product1.Photo.CopyTo(new FileStream(filepath, FileMode.Create));
            }

            Products p = new Products
            {
                ProductName = product1.ProductName,
                Description = product1.Description,
                Preview = product1.Preview,
                Features = product1.Features,
                CategoryId = product1.CategoryId,
                ProductNumber = product1.ProductNumber,
                UnitPrice = product1.UnitPrice,
                UnitsInStock = product1.UnitsInStock,
                Picture = filename
            };
            eshopContext.Products.Add(p);
            eshopContext.SaveChanges();
            ViewBag.Success = "Ürün Eklendi";

            return View();
        }
    }
}
