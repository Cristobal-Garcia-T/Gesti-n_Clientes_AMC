namespace AccesoDB.Modelos
{
    public class Tarea : Modelo
    {
        public required string IdConsultor { get; set; } = string.Empty;
        public int? IdEvento { get; set; }
        public int? IdCaso { get; set; }
        public required string Nombre { get; set; } = string.Empty;
        public required string Descripcion { get; set; } = string.Empty;
        public required string Prioridad { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEvento { get; set; }
    }
}
