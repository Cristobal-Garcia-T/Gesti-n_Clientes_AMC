namespace AccesoDB.Modelos;

public class Usuario : Modelo
{
    public required string Nombre { get; set; }
    public required string Contrasena { get; set; }
    public required string Correo { get; set; }
    public required int Telefono { get; set; }
}