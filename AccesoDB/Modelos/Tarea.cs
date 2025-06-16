namespace AccesoDB.Modelos
{
    public class Tarea : IModelo
    {
        public required int Id { get; set; }
        public required int IdConsultor { get; set; }
        public int? IdCaso { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public required string Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaEvento { get; set; }
    }
}
