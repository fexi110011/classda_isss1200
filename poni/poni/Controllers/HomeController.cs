using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoniaFx.DAL;
using PoniaFx.Models;

namespace PoniaFx.Controllers
{



    public class HomeController : Controller
    {

        FxDbContext _context;

        public HomeController(FxDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slayder> slayders = await _context.Slayders.ToListAsync();

            return View(slayders);
        }
    }
}
