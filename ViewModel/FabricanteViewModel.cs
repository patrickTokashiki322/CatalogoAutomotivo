using System.ComponentModel.DataAnnotations;

namespace CatalogoAutomotivo.ViewModel
{
    public class FabricanteViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string Slogan { get; set; }

        [Required]
        public string DataFundacao { get; set; }

        [Required]
        public string Fundador { get; set; }

        [Required]
        public string Sede { get; set; }

        [Required]
        public string WebSite { get; set; }
    }
}
