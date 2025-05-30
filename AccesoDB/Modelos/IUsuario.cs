namespace AccesoDB.Modelos;

public interface IUsuario
{
    public string? Id { get; set; }
    public string? Contrasena { get; set; }
    public string? Nombres { get; set; }
    public string? Apellidos { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
}