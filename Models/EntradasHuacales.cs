using System.ComponentModel.DataAnnotations;

namespace P1_AP1_WilliamRodriguez.Models;

public class EntradasHuacales
{
    [Key]
    public int EntradaId {  get; set; }

    public string NombreCliente { get; set; } = string.Empty;

    public int Cantidad { get; set; }

    public int Precio { get; set; }

    public DateTime FechaInicio{ get; set; } = DateTime.UtcNow;
    public DateTime? FechaFin { get; set; }

}
