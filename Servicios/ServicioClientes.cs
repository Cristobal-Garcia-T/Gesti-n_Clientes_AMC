using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios;

public class ServicioClientes : IServicio<Cliente>
{
    private readonly ContextoDb _contexto;

    public ServicioClientes(ContextoDb contexto)
    {
        _contexto = contexto;
    }
    public List<Cliente> RecuperarTodos() => _contexto.Clientes.ToList();

    public Cliente? RecuperarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public void Agregar(Cliente modelo)
    {
        _contexto.Clientes.Add(modelo);
        _contexto.SaveChanges();
    }

    public void Editar(Cliente modelo)
    {
        var existente = _contexto.Clientes.Find(modelo.Id);
        if (existente != null)
        {
            existente.Id = modelo.Id;
            existente.Rut = modelo.Rut;
            existente.Nombre = modelo.Nombre;
            existente.Correo = modelo.Correo;
            existente.Direccion = modelo.Direccion;
            existente.Telefono = modelo.Telefono;
            existente.NumeroCasos = modelo.NumeroCasos;
            existente.Tipo = modelo.Tipo;
            existente.Actividad = modelo.Actividad;
            existente.Casos = modelo.Casos;
            existente.ConsultorId = modelo.ConsultorId;
            existente.Consultor = modelo.Consultor;
                
            _contexto.SaveChanges();
        }
    }

    public void Eliminar(int id)
    {
        var cliente = _contexto.Clientes.Find(id);
        if (cliente != null)
        {
            _contexto.Clientes.Remove(cliente);
            _contexto.SaveChanges();
        }
    }
}