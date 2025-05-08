using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class Caso
    {
        [Key]
        public int Id { get; set; }
        public string? IdCliente { get; set; }
        public string? IdBeneficiario { get; set; }
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
