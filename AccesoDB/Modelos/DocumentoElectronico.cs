namespace AccesoDB.Modelos
{
    public class DocumentoElectronico
    {
        public string? IdentificadorCaso { get; set; }
        public string? Nombre { get; set; }
        public string? Extension { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public float Tamaño { get; set; }
    }
}
