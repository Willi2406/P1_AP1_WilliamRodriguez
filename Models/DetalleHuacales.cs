using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P1_AP1_WilliamRodriguez.Models
{
    public class DetalleHuacales
    {
        [Key]
        public int DetalleId { get; set; }

        public int EntradaId { get; set; }

        public int TipoId { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        [NotMapped]
        public string? DescripcionTipoHuacal { get; set; }
    }
}
