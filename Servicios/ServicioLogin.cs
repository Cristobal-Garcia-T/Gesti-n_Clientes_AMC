using System.Security.Cryptography;
using System.Text;
using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioLogin
{
    private readonly ContextoDb _contexto;
    public IUsuario? UsuarioActual { get; set; }
    public bool Autenticado => UsuarioActual != null;
    
    public event EventHandler<IUsuario?>? UsuarioActualChanged;

    public ServicioLogin(ContextoDb contexto)
    {
        _contexto = contexto;
    }
    
    public IUsuario? Login(string? id, string? pass, string? tipo)
    {
        pass = Encriptar(pass);
        if (tipo == "Administrador")
        {
            var adminBuscado = _contexto.Administradores.Find(id);
            if (adminBuscado != null && adminBuscado.Contrasena == pass)
            {
                UsuarioActual = adminBuscado;
                UsuarioActualChanged?.Invoke(this, adminBuscado);
                return UsuarioActual;
            }
        }

        if (tipo == "Consultor")
        {
            var consultorBuscado = _contexto.Consultores.Find(id);
            if (consultorBuscado != null && consultorBuscado.Contrasena == pass)
            {
                UsuarioActual = consultorBuscado;
                UsuarioActualChanged?.Invoke(this, consultorBuscado);
                return UsuarioActual;
            }
        }
        
        return null;
    }

    public void Logout()
    {
        UsuarioActual = null;
        UsuarioActualChanged?.Invoke(this, null);
    }

    private string Encriptar(string? pass)
    {
        var hash = String.Empty;
        if (pass != null)
        {
            byte[] encriptado = SHA256.HashData(Encoding.UTF8.GetBytes(pass));
            foreach (byte b in encriptado)
            {
                hash += b.ToString("x2");
            }
        }
        return hash;
    }
}