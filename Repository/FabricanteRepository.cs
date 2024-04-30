using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.Repository.Interfaces;
using CatalogoAutomotivo.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace CatalogoAutomotivo.Repository
{
    public class FabricanteRepository : IFabricante
    {
        private readonly AppDbContext _appDbContext;

        public FabricanteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Fabricante? ObterFabricantePorId(int id)
        {
            return _appDbContext.Fabricante.Where(f => f.Id == id).FirstOrDefault();
        }

        public void CriarFabricante(Fabricante fabricante)
        {
            _appDbContext.Fabricante.Add(fabricante);
            _appDbContext.SaveChanges();
        }

        public void DeletarFabricante(Fabricante fabricante)
        {
            throw new NotImplementedException();
        }

        public void EditarFabricante(Fabricante fabricante)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Fabricante>> ListarFabricante()
        {
            return await _appDbContext.Fabricante.ToListAsync();
        }
    }
}
