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
}