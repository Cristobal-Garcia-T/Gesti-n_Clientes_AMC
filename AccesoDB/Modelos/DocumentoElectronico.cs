using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class DocumentoElectronico : IModelo
    {
        [Key] public required string Id { get; set; } = string.Empty;
        public required string IdCaso { get; set; } = string.Empty;
        public required string Nombre { get; set; } = string.Empty;
        public required string Extension { get; set; } = string.Empty;
        public required string Direccion { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public float Tamaño { get; set; }
    }
}
