using Microsoft.AspNetCore.Mvc;

namespace PoniaFx.Areas.FxArea_MVC.Controllers
{
    public class Fx_Dashboard : Controller
    {
        [Area("FxArea_MVC")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
