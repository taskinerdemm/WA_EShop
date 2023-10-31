using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WA_EShop.Models.DB;

namespace WA_EShop.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private EshopContext _context;
        public MenuViewComponent(EshopContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Categories> categories = await _context.Categories.ToListAsync();

            return View(categories);
        }
    }
}
