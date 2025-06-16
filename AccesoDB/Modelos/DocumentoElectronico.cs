namespace AccesoDB.Modelos
{
    public class DocumentoElectronico : IModelo
    {
        public required int Id { get; set; }
        public required int IdCaso { get; set; }
        public required string Nombre { get; set; }
        public required string Extension { get; set; } 
        public required string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public float Tamaño { get; set; }
    }
}
