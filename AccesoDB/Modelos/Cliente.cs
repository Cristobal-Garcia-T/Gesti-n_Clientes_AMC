namespace AccesoDB.Modelos;

public class Cliente : IModelo, IEquatable<Cliente>
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Rut { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public int Telefono { get; set; }
    public string Tipo { get; set; }
    public string Actividad { get; set; }
    public int NumeroCasos { get; set; }
    public int ConsultorId { get; set; }
    public Consultor Consultor { get; set; }
    
    public List<Caso> Casos { get; set; }
    public bool Equals(Cliente? other)
    {
        return other != null && other.Id == Id;
    }
}