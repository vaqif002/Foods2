using Foods1.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Foods1.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;
        public MenuViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> Invokeasync()
        {
            return View();
        }
    }
}
