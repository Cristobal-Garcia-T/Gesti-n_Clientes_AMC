namespace AccesoDB.Modelos
{
    public class Tarea : IModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Prioridad { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaEvento { get; set; }
        
        public int ConsultorId { get; set; }
        public Consultor Consultor { get; set; }
        
        public int? CasoId { get; set; }
        public Caso Caso { get; set; }
    }
}
