using CatalogoAutomotivo.Common;
using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.Repository.Interfaces;
using CatalogoAutomotivo.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

namespace CatalogoAutomotivo.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly AppDbContext _context;
        private readonly ICategoria _categoriaRepository;
        private readonly IFileProvider _fileProvider;

        public CategoriasController(AppDbContext context, ICategoria categoriaReository, IFileProvider fileProvider)
        {
            _context = context;
            _categoriaRepository = categoriaReository;
            _fileProvider = fileProvider;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _categoriaRepository.ListarCategorias());
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FirstOrDefaultAsync(c => c.Id == id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoriaViewModel categoriaViewModel, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var categoriaMer = new Categoria();

                categoriaMer.NomeCategoria = categoriaViewModel.NomeCategoria;

                if (file.Length > 0)
                {
                    var categoriaLogoPath = @"Content/Uploads/Categoria/";

                    new FileManager(_fileProvider).CreateFile(categoriaLogoPath, file);

                    categoriaMer.Img = categoriaLogoPath + file.FileName;
                }

                _context.Categoria.Add(categoriaMer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CategoriaViewModel categoriaViewModel, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var categoriaMer = _categoriaRepository.ObterCategoriaPorId(categoriaViewModel.Id);

                if (categoriaMer == null)
                {
                    return NotFound();
                }

                categoriaMer.NomeCategoria = categoriaViewModel.NomeCategoria;

                var categoriaLogoPath = @"Content/Uploads/Categoria/";
                string fullFilePath = Path.Combine(categoriaLogoPath, file.FileName);


                if (categoriaMer.Img != fullFilePath)
                {
                    new FileManager(_fileProvider).DeleteFile(categoriaMer.Img);
                }

                if (file.Length > 0)
                {

                    new FileManager(_fileProvider).CreateFile(categoriaLogoPath, file);

                    categoriaMer.Img = categoriaLogoPath + file.FileName;
                }

                _context.Categoria.Update(categoriaMer);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return View(categoriaViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria != null)
            {
                if (categoria.Img != null)
                {
                    new FileManager(_fileProvider).DeleteFile(categoria.Img);
                }

                _context.Categoria.Remove(categoria);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
