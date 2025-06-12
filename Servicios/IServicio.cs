using AccesoDB.Modelos;

namespace Servicios;

public interface IServicio<T> where T : IModelo
{
    List<T> RecuperarTodos();
    T? RecuperarPorId(string id);
    void Agregar(T modelo);
    void Editar(T modelo);
    void Eliminar(string id);
}