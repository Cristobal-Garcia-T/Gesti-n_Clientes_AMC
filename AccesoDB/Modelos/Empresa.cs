namespace AccesoDB.Modelos
{
    public class Empresa : Cliente
    {
        public required string RazonSocial { get; set; }
        public required string Actividad { get; set; }
        public required string Tipo { get; set; } = "Empresa";
    }
}
