namespace AccesoDB.Modelos
{
    public class Caso
    {
        public string? Identificador { get; set; }
        public string? IdentificadorCliente { get; set; }
        public string? IdentificadorBeneficiario { get; set; }
        public string? ServicioContratado { get; set; }
        public string? MedioPago { get; set; }
        public string? DocumentoTributario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaLimiteInformeCierre { get; set; }
        public string? Estado { get; set; }
        public string? Resumen { get; set; }
        public string? InformeResolucion { get; set; }
        public string? ObservacionesEspeciales { get; set; }
    }
}
