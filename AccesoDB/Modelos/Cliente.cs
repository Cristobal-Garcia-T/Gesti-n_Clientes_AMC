namespace AccesoDB.Modelos;

public class Cliente : IModelo
{
    public int Id { get; set; }
    public string Rut { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }
    public int Telefono { get; set; }
    public int NumeroCasos { get; set; }
    
    public int ConsultorId { get; set; }
    public Consultor Consultor { get; set; }
    
    public List<Caso> Casos { get; set; }
}