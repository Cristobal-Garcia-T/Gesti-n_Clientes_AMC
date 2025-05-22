using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioAdministradores
{
    //Servico encargardo de operaciones CRUD sobre tabla "Administradores"
    private readonly ContextoDb _contexto;

    public ServicioAdministradores(ContextoDb contexto)
    {
        _contexto = contexto;
    }

    //Recupera todos los elementos de la tabla y los devuelve como una lista
    public List<Administrador> RecuperarTodos() => _contexto.Administradores.ToList();

    //Vetifica si la tabla está vacía
    public bool TablaVacia() => !_contexto.Administradores.Any();

    public void AgregarAdministrador(Administrador admin)
    {
        //Recibe un objeto admin y lo regsitra en la tabla, EF se encarga de las transformaciones necesarias
        _contexto.Administradores.Add(admin);
        _contexto.SaveChanges();
    }
}