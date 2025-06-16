namespace AccesoDB.Modelos
{
    public class Caso : IModelo
    {
        public required int Id { get; set; }
        public required int IdCliente { get; set; }
        public required int IdBeneficiario { get; set; }
        public required string ServicioContratado { get; set; }
        public required string MedioPago { get; set; }
        public required string DocumentoTributario { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaLimiteInformeCierre { get; set; }
        public required string Estado { get; set; }
        public required string Resumen { get; set; }
        public string? InformeResolucion { get; set; }
        public string? ObservacionesEspeciales { get; set; }
    }
}
