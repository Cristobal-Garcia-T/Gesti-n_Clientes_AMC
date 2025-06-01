namespace AccesoDB.Modelos
{
    public class Beneficiario : Persona
    {
        public int NumeroCasos { get; set; }
        public string? Genero { get; set; }
        public string? Nacionalidad { get; set; }
        public DateTime? FechaEmisionPasaporte { get; set; }
        public DateTime? FechaVencimientoPasaporte { get; set; }
        public string? TipoPermanencia { get; set; }
        public string? VigenciaVisa { get; set; }
        public string? Ocupacion { get; set; }
        public string? PaisResidencia { get; set; } 
        public string? Direccion { get; set; }
    }
}
