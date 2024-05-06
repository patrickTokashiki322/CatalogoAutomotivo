using System.ComponentModel.DataAnnotations;

namespace CatalogoAutomotivo.ViewModel
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }

        [Required]
        public string NomeCategoria { get; set; }
    }
}
