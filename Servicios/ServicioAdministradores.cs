using System.Security.Cryptography;
using System.Text;
using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioAdministradores
{
    private readonly ContextoDb _contexto;

    public ServicioAdministradores(ContextoDb contexto)
    {
        _contexto = contexto;
    }

    public List<Administrador> RecuperarTodos() => _contexto.Administradores.ToList();

    public bool TablaVacia() => !_contexto.Administradores.Any();

    public void AgregarAdministrador(Administrador admin)
    {
        _contexto.Administradores.Add(admin);
        _contexto.SaveChanges();
    }
    
    private string Encriptar(string txt)
    {
        string hash = String.Empty;
        byte[] encriptado = SHA256.HashData(Encoding.UTF8.GetBytes(txt));
        foreach (byte b in encriptado)
        {
            hash += b.ToString("x2");
        }
        return hash;
    }
}