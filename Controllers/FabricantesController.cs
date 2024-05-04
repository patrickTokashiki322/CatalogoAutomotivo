using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.ViewModel;
using CatalogoAutomotivo.Repository.Interfaces;
using Microsoft.Extensions.FileProviders;
using CatalogoAutomotivo.Common;

namespace CatalogoAutomotivo.Controllers
{
    public class FabricantesController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IFabricante _fabricanteRepository;
        private readonly IFileProvider _fileProvider;

        public FabricantesController(AppDbContext context, IFabricante fabricanteRepository, IFileProvider fileProvider)
        {
            _context = context;
            _fabricanteRepository = fabricanteRepository;
            _fileProvider = fileProvider;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _fabricanteRepository.ListarFabricante());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fabricante = await _context.Fabricante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fabricante == null)
            {
                return NotFound();
            }

            return View(fabricante);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RazaoSocial,Slogan,DataFundacao,Fundador,Sede,WebSite")] FabricanteViewModel fabricante, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var fabricanteMer = new Fabricante();

                fabricanteMer.RazaoSocial = fabricante.RazaoSocial;
                fabricanteMer.Slogan = fabricante.Slogan;
                fabricanteMer.DataFundacao = fabricante.DataFundacao;
                fabricanteMer.Fundador = fabricante.Fundador;
                fabricanteMer.Sede = fabricante.Sede;
                fabricanteMer.WebSite = fabricante.WebSite;

                if (file.Length > 0)
                {
                    var fabricanteLogoPath = @"Content/Uploads/Fabricantes/";

                    new FileManager(_fileProvider).CreateFile(fabricanteLogoPath, file);

                    fabricanteMer.Img = fabricanteLogoPath + file.FileName;
                }

                _context.Fabricante.Add(fabricanteMer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fabricante);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fabricante = await _context.Fabricante.FindAsync(id);
            if (fabricante == null)
            {
                return NotFound();
            }
            return View(fabricante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RazaoSocial,Slogan,DataFundacao,Fundador,Sede,WebSite")] FabricanteViewModel fabricante, IFormFile file)
        {
            var fabricanteMer = _fabricanteRepository.ObterFabricantePorId(id);

            if (fabricanteMer == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (file.Length > 0)
                {
                    var fabricanteLogoPath = @"Content/Uploads/Fabricantes/";

                    new FileManager(_fileProvider).CreateFile(fabricanteLogoPath, file);

                    fabricanteMer.Img = fabricanteLogoPath + file.FileName;
                }

                fabricanteMer.RazaoSocial = fabricante.RazaoSocial;
                fabricanteMer.Slogan = fabricante.Slogan;
                fabricanteMer.DataFundacao = fabricante.DataFundacao;
                fabricanteMer.Fundador = fabricante.Fundador;
                fabricanteMer.Sede = fabricante.Sede;
                fabricanteMer.WebSite = fabricante.WebSite;

                _context.Update(fabricanteMer);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            return View(fabricante);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fabricante = await _context.Fabricante
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fabricante == null)
            {
                return NotFound();
            }

            return View(fabricante);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fabricante = await _context.Fabricante.FindAsync(id);
            if (fabricante != null)
            {
                _context.Fabricante.Remove(fabricante);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FabricanteExists(int id)
        {
            return _context.Fabricante.Any(e => e.Id == id);
        }
    }
}
