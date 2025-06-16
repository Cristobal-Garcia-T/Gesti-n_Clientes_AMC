namespace AccesoDB.Modelos
{
    public class DocumentoElectronico : IModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Extension { get; set; } 
        public string Direccion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public float Tamaño { get; set; }
        
        public int CasoId { get; set; }
        public Caso Caso { get; set; }
    }
}
