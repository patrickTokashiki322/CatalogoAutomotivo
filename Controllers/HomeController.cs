using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.Repository;
using CatalogoAutomotivo.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatalogoAutomotivo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoria _categoriaRepository;

        public HomeController(ILogger<HomeController> logger, ICategoria categoriaRepository)
        {
            _logger = logger;
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _categoriaRepository.ListarCategorias());
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
