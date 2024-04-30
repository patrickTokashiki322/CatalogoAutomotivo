using Microsoft.AspNetCore.Mvc;

namespace CatalogoAutomotivo.Controllers
{
    public class Categorias : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
