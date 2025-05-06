namespace AccesoDB.Modelos
{
    public class Administrador : Persona
    {
        public string? Contrasena { get; set; }
        public int CodigoRecuperación { get; set; }
    }
}