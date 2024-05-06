using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CatalogoAutomotivo.ViewModel
{
    public class FabricanteViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Slogan")]
        public string Slogan { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Data de fundação")]
        public string DataFundacao { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Fundador")]
        public string Fundador { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("Sede")]
        public string Sede { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [DisplayName("WebSite")]
        public string WebSite { get; set; }

        [DisplayName("Logo")]
        public string? Img { get; set; }
    }
}
