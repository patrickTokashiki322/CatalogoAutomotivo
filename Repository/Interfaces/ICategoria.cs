using CatalogoAutomotivo.MER;

namespace CatalogoAutomotivo.Repository.Interfaces
{
    public interface ICategoria
    {
        Categoria? ObterCategoriaPorId(int id);

        void CriarCategoria(Categoria categoria);
        Task<ICollection<Categoria>> ListarCategorias();
    }
}
