using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class Empresa
    {
        [Key] 
        public string? Rut { get; set; }
        public string? IdConsultor { get; set; }
        public int NumeroCasos { get; set; }
        public string? RazonSocial { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
        public string? ActividadEconomica { get; set; }
    }
}
