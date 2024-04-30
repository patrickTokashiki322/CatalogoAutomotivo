using CatalogoAutomotivo.MER;
using Microsoft.EntityFrameworkCore;

namespace CatalogoAutomotivo.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Tracao> Tracao { get; set; }
        public DbSet<Transmissao> Transmissao { get; set; }
        public DbSet<Aspiracao> Aspiracao { get; set; }
        public DbSet<Combustivel> Combustivel { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<Alimentacao> Alimentacao { get; set; }
        public DbSet<Carro> Carro { get; set; }
    }
}
