using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos;

public class Usuario : IModelo
{
    [Key] public required string Id { get; set; } = string.Empty;
    public required string Nombre { get; set; } = string.Empty;
    public required string Contrasena { get; set; } = string.Empty;
    public required string Correo { get; set; } = string.Empty;
    public required int Telefono { get; set; }
}