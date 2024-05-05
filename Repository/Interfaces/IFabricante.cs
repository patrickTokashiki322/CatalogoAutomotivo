using CatalogoAutomotivo.MER;
using System.Drawing;

namespace CatalogoAutomotivo.Repository.Interfaces
{
    public interface IFabricante
    {
        Fabricante? ObterFabricantePorId(int id);
        void CriarFabricante(Fabricante fabricante);
        Task<ICollection<Fabricante>> ListarFabricante();
    }
}
