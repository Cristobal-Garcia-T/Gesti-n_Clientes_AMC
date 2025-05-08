using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class DocumentoElectronico
    {
        [Key]
        public int Id { get; set; }
        public string? IdCaso { get; set; }
        public string? Nombre { get; set; }
        public string? Extension { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public float Tamaño { get; set; }
    }
}
