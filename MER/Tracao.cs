using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Tracao")]
    public class Tracao
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string TipoTracao { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
