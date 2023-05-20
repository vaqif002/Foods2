using Foods1.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Foods1.Controllers
{
    public class HomeController : Controller
    {

private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }
    public IActionResult Index()
        {
            return View();
        }
    }
}
