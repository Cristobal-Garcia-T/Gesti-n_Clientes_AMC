using System.Security.Cryptography;
using System.Text;

namespace AccesoDB.Modelos
{
    public class Administrador : Persona
    {
        private string? _contrasena;
        public string? Contrasena
        {
            get => _contrasena;
            set
            {
                //Retorna un hash en formato string a partir de una cadena de texto,
                //usa el algoritmo SHA-256 para generar el hash
                string hash = String.Empty;
                if (value != null)
                {
                    byte[] encriptado = SHA256.HashData(Encoding.UTF8.GetBytes(value));
                    foreach (byte b in encriptado)
                    {
                        hash += b.ToString("x2");
                    }
                }
                _contrasena = hash;
            }
        }

        public int CodigoRecuperación { get; set; }
    }
}