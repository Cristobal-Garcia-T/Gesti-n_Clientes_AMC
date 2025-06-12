using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos;

public class Cliente : IModelo
{
    [Key] public required string Id { get; set; } = string.Empty;
    public required string IdConsultorio { get; set; } = string.Empty;
    public required string Correo { get; set; } = string.Empty;
    public required string Direccion { get; set; } = string.Empty;
    public int Telefono { get; set; }
    public int NumeroCasos { get; set; }
}