using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class Tarea
    {
        [Key]
        public int Id { get; set; }
        public string? IdConsultor { get; set; }
        public int? IdEvento { get; set; }
        public int? IdCaso { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEvento { get; set; }
    }
}
