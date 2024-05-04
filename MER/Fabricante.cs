using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Fabricante")]
    public class Fabricante
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Quantidade máxima de caracteres é 50")]
        public string RazaoSocial { get; set; }

        [MaxLength(100, ErrorMessage = "Quantidade máxima de caracteres é 100")]
        public string Slogan { get; set; }
        public string DataFundacao { get; set; }

        [MaxLength(100, ErrorMessage = "Quantidade máxima de caracteres é 100")]
        public string Fundador { get; set; }

        [MaxLength(50, ErrorMessage = "Quantidade máxima de caracteres é 50")]
        public string Sede { get; set; }

        [MaxLength(100, ErrorMessage = "Quantidade máxima de caracteres é 100")]
        public string WebSite { get; set; }

        public string? Img { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
