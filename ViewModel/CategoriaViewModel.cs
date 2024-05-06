using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CatalogoAutomotivo.ViewModel
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Nome")]
        public string NomeCategoria { get; set; }

        [DisplayName("Logo")]
        public string? Img { get; set; }
    }
}
