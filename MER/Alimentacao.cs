using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Alimentacao")]
    public class Alimentacao
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "Quantidade máxima de caracteres é 30")]
        public string TipoAlimentacao { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
