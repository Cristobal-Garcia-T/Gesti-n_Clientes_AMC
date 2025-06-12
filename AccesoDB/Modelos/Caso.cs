namespace AccesoDB.Modelos
{
    public class Caso : Modelo
    {
        public required string IdCliente { get; set; } = string.Empty;
        public required string IdBeneficiario { get; set; } = string.Empty;
        public required string ServicioContratado { get; set; } = string.Empty;
        public required string MedioPago { get; set; } = string.Empty;
        public required string DocumentoTributario { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaLimiteInformeCierre { get; set; }
        public required string Estado { get; set; } = string.Empty;
        public required string Resumen { get; set; } = string.Empty;
        public string? InformeResolucion { get; set; }
        public string? ObservacionesEspeciales { get; set; }
    }
}
