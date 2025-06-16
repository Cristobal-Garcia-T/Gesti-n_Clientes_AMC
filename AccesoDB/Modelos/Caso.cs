namespace AccesoDB.Modelos
{
    public class Caso : IModelo
    {
        public int Id { get; set; }
        public string ServicioContratado { get; set; }
        public string MedioPago { get; set; }
        public string DocumentoTributario { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaLimiteInformeCierre { get; set; }
        public string Estado { get; set; }
        public string Resumen { get; set; }
        public string? InformeResolucion { get; set; }
        public string? ObservacionesEspeciales { get; set; }
        
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        
        public int BeneficiarioId { get; set; }
        public Beneficiario Beneficiario { get; set; }
        
        public int ConsultorId { get; set; }
        public Consultor Consultor { get; set; }
    }
}
