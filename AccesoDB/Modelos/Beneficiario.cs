using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class Beneficiario : IModelo
    {
        [Key] public required string Id { get; set; } = string.Empty;
        public required string Nombre { get; set; } = string.Empty;
        public required int Telefono { get; set; }
        public required string Direccion { get; set; } = string.Empty;
        public required string Correo { get; set; } = string.Empty;
        public required string Genero { get; set; } = string.Empty;
        public required string Nacionalidad { get; set; } = string.Empty;
        public required DateTime FechaEmisionPasaporte { get; set; }
        public required DateTime FechaVencimientoPasaporte { get; set; }
        public required string Permanencia { get; set; } = string.Empty;
        public required string VigenciaVisa { get; set; } = string.Empty;
        public required string Ocupacion { get; set; } = string.Empty;
        public required string PaisResidencia { get; set; } = string.Empty;
        
    }
}
