namespace AccesoDB.Modelos;

public class Cliente : Modelo
{
    public required string IdConsultorio { get; set; } = string.Empty;
    public required string Correo { get; set; } = string.Empty;
    public required string Direccion { get; set; } = string.Empty;
    public int Telefono { get; set; }
    public int NumeroCasos { get; set; }
}