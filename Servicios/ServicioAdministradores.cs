using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioAdministradores : IServicio<Administrador>
{
    //Servico encargardo de operaciones CRUD sobre tabla "Administradores"
    private readonly ContextoDb _contexto;

    public ServicioAdministradores(ContextoDb contexto)
    {
        _contexto = contexto;
    }
    public List<Administrador> RecuperarTodos() => _contexto.Administradores.ToList();
    public Administrador? RecuperarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Agregar(Administrador admin)
    {
        _contexto.Administradores.Add(admin);
        _contexto.SaveChanges();
    }

    public void Editar(Administrador modelo)
    {
        throw new NotImplementedException();
    }

    public void Eliminar(int id)
    {
        throw new NotImplementedException();
    }

    //Vetifica si la tabla está vacía
    public bool TablaVacia() => !_contexto.Administradores.Any();
}