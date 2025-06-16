namespace AccesoDB.Modelos;

public class Usuario : IModelo
{
    public int Id { get; set; }
    public string Rut { get; set; }
    public string Nombre { get; set; }
    public string Contrasena { get; set; }
    public string Correo { get; set; }
    public int Telefono { get; set; }
}