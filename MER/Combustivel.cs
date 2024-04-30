using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Combustivel")]
    public class Combustivel
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string NomeCombustivel { get; set; }
        public ICollection<Carro> Carros { get; set; }
    }
}
