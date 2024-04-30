using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Transmissao")]
    public class Transmissao
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string TipoTransmissao { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
