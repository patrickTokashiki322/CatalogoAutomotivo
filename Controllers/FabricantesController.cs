using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.ViewModel;
using CatalogoAutomotivo.Repository;
using CatalogoAutomotivo.Repository.Interfaces;
using System.Drawing;
using Microsoft.Extensions.FileProviders;

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

        // GET: Fabricantes
        public async Task<IActionResult> Index()
        {
            return View(await _fabricanteRepository.ListarFabricante());
        }

        // GET: Fabricantes/Details/5
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

        // GET: Fabricantes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fabricantes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RazaoSocial,Slogan,DataFundacao,Fundador,Sede,WebSite")] FabricanteViewModel fabricante)
        {
            var fabricanteMer = new Fabricante();

            fabricanteMer.RazaoSocial = fabricante.RazaoSocial;
            fabricanteMer.Slogan = fabricante.Slogan;
            fabricanteMer.DataFundacao = fabricante.DataFundacao;
            fabricanteMer.Fundador = fabricante.Fundador;
            fabricanteMer.Sede = fabricante.Sede;
            fabricanteMer.WebSite = fabricante.WebSite;
            //fabricanteMer.Img = fabricante.Img;

            if (ModelState.IsValid)
            {
                _context.Fabricante.Add(fabricanteMer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fabricante);
        }

        // GET: Fabricantes/Edit/5
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

        // POST: Fabricantes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
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

                    var folderInfo = _fileProvider.GetFileInfo(Path.Combine("wwwroot", fabricanteLogoPath));
                    string filePath = Path.Combine(folderInfo.PhysicalPath, file.FileName);
                    
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await file.CopyToAsync(stream);
                    }

                    // string filePath = _fileProvider.GetFileInfo(@"Content\Uploads\Fabricantes" + file.FileName).PhysicalPath;

                    fabricanteMer.Img = fabricanteLogoPath + file.FileName;
                }

                //byte[] bytes = System.IO.File.ReadAllBytes();
                //string imageToBase64 = Convert.ToBase64String(bytes);

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

        // GET: Fabricantes/Delete/5
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

        // POST: Fabricantes/Delete/5
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
