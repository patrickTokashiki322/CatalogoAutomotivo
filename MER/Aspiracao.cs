using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Aspiracao")]
    public class Aspiracao
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string TipoAspiracao { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
