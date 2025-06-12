namespace AccesoDB.Modelos
{
    public class Empresa : Cliente
    {
        public required string RazonSocial { get; set; } = string.Empty;
        public required string Actividad { get; set; } = string.Empty;
    }
}
