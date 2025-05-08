using System.ComponentModel.DataAnnotations;

namespace AccesoDB.Modelos
{
    public class Persona
    {
        [Key]
        public string? Id { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public string? Direccion { get; set; }
    }
}