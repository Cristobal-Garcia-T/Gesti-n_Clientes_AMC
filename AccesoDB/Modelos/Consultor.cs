namespace AccesoDB.Modelos
{
    public class Consultor : Usuario, IEquatable<Consultor>
    {
        public int NumeroClientes { get; set; }
        public int NumeroCasos { get; set; }
        
        public List<Caso> Casos { get; set; }
        public List<Cliente> Clientes { get; set; }
        public bool Equals(Consultor? other)
        {
            return other != null && Id == other.Id;
        }
    }
}