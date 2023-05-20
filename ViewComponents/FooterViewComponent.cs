using Foods1.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Foods1.ViewComponents
{
    public class FooterViewComponent : ViewComponent

    {
        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = _context;
        }
        public async Task<IViewComponentResult> Invokeasync()
        {
            return View();
        }
    }
}
