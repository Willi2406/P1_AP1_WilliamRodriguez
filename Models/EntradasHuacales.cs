using System.ComponentModel.DataAnnotations;

namespace P1_AP1_WilliamRodriguez.Models;

public class EntradasHuacales
{
    [Key]
    public int EntradaId {  get; set; }

    [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
    public string NombreCliente { get; set; } = string.Empty;

    [Range(1, 100, ErrorMessage = "La cantidad debe ser mayor o igual a 1")]
    public int Cantidad { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 1")]
    public int Precio { get; set; }
    public DateTime Fecha{ get; set; } = DateTime.UtcNow;

}
