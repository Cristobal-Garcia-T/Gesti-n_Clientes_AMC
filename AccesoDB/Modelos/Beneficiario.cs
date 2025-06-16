namespace AccesoDB.Modelos
{
    public class Beneficiario : IModelo
    {
        public required int Id { get; set; }
        public required string Rut { get; set; }
        public required string Nombre { get; set; }
        public required int Telefono { get; set; }
        public required string Direccion { get; set; }
        public required string Correo { get; set; }
        public required string Genero { get; set; }
        public required string Nacionalidad { get; set; }
        public required DateTime FechaEmisionPasaporte { get; set; }
        public required DateTime FechaVencimientoPasaporte { get; set; }
        public required string Permanencia { get; set; }
        public required string VigenciaVisa { get; set; }
        public required string Ocupacion { get; set; }
        public required string PaisResidencia { get; set; }
        
    }
}
