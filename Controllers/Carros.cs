using Microsoft.AspNetCore.Mvc;

namespace CatalogoAutomotivo.Controllers
{
    public class Carros : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
