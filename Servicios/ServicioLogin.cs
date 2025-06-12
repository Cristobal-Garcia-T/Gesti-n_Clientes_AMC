using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioLogin
{
    private readonly ContextoDb _contexto;
    public Usuario? UsuarioActual { get; set; }
    public bool Autenticado => UsuarioActual != null;
    
    public event EventHandler<Usuario?>? UsuarioActualChanged;

    public ServicioLogin(ContextoDb contexto)
    {
        _contexto = contexto;
    }
    
    public Usuario? Login(string? id, string? pass, string? tipo)
    {
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
}