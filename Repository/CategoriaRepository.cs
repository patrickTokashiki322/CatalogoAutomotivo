using CatalogoAutomotivo.Context;
using CatalogoAutomotivo.MER;
using CatalogoAutomotivo.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAutomotivo.Repository
{
    public class CategoriaRepository : ICategoria
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CriarCategoria(Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            _context.SaveChanges();
        }

        public async Task<ICollection<Categoria>> ListarCategorias()
        {
            return await _context.Categoria.ToListAsync();
        }

        public Categoria? ObterCategoriaPorId(int id)
        {
            return _context.Categoria.Where(c => c.Id == id).FirstOrDefault();
        }
    }
}
