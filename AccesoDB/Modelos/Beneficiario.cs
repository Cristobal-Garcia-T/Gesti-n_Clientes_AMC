namespace AccesoDB.Modelos
{
    public class Beneficiario : IModelo
    {
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaEmisionPasaporte { get; set; }
        public DateTime FechaVencimientoPasaporte { get; set; }
        public string Permanencia { get; set; }
        public string VigenciaVisa { get; set; }
        public string Ocupacion { get; set; }
        public string PaisResidencia { get; set; }
        
        public List<Caso> Casos { get; set; }
    }
}
