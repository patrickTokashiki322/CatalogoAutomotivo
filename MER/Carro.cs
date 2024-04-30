using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAutomotivo.MER
{
    [Table("Carro")]
    public class Carro
    {
        public int Id { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string Nome { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string Modelo { get; set; }
        public Fabricante Fabricante { get; set; }
        public DataType AnoFabricacao { get; set; }
        public Categoria Categoria { get; set; }

        [MaxLength(30, ErrorMessage = "Quantidade máxima de caracteres é 30")]
        public string Motor { get; set; }
        public Alimentacao Alimentacao { get; set; }
        public Aspiracao Aspiracao { get; set; }
        public int Potencia { get; set; }
        public int RotacaoMaxima { get; set; }
        public int PrecoTabela { get; set; }
        public Combustivel Combustivel { get; set; }
        public int CapacidadeCombustivel { get; set; }
        public int QuantidadePortas { get; set; }
        public int QuantidadeLugares { get; set; }
        public Tracao Tracao { get; set; }
        public Transmissao Transmissao { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de caracteres é 10")]
        public string PneusDianteiros { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de caracteres é 10")]
        public string PneusTraseiros { get; set; }
        public int Peso { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int ConsumoUrbano { get; set; }
        public int ConsumoRodoviario { get; set; }
        public int AutonomiaUrbana { get; set; }
        public int AutonomiaRodoviaria { get; set; }
        public string Foto { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string FreioDianteiro { get; set; }

        [MaxLength(20, ErrorMessage = "Quantidade máxima de caracteres é 20")]
        public string FreioTraseiro { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de caracteres é 10")]
        public string OleoMotor { get; set; }
    }
}
