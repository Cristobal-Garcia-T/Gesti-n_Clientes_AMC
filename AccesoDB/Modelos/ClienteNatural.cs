namespace AccesoDB.Modelos
{
    public class ClienteNatural : Cliente
    {
        public required string Nombre { get; set; }
        public required string Tipo { get; set; } = "Cliente Natural";
    }
}
