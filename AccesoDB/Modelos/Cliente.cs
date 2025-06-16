namespace AccesoDB.Modelos;

public class Cliente : IModelo
{
    public required int Id { get; set; }
    public required int IdConsultor { get; set; }
    public required string Rut { get; set; }
    public required string Correo { get; set; }
    public required string Direccion { get; set; }
    public int Telefono { get; set; }
    public int NumeroCasos { get; set; }
}