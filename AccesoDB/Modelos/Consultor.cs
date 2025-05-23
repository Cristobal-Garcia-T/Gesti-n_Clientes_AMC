namespace AccesoDB.Modelos
{
    public class Consultor : Persona
    {
        public string? Contrasena { get; set; }
        public int NumeroClientes { get; set; }
        public int NumeroCasos { get; set; }
        public string? NombreUsuario { get; set; }
    }
}