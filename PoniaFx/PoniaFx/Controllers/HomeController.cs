using Microsoft.AspNetCore.Mvc;

namespace PoniaFx.Controllers
{
    public class HomeController : Controller
    {

        

        public IActionResult Index()
        {
            return View();
        }
    }
}
