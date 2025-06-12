using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios
{
    public class ServicioConsultores : IServicio<Consultor>
    {
         private readonly ContextoDb _contexto;

        public ServicioConsultores(ContextoDb contexto)
        {
            _contexto = contexto;
        }

        public List<Consultor> RecuperarTodos() => _contexto.Consultores.ToList();
        public Consultor? RecuperarPorId(string id)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Consultor consultor)
        {
            _contexto.Consultores.Add(consultor);
            _contexto.SaveChanges();
        }

        public void Editar(Consultor consultorSeleccionado)
        {
            var existente = _contexto.Consultores.Find(consultorSeleccionado.Id);
            if (existente != null)
            {
                _contexto.SaveChanges();
            }
        }

        public void Eliminar(string? id)
        {
            var consultor = _contexto.Consultores.Find(id);
            if (consultor != null)
            {
                _contexto.Consultores.Remove(consultor);
                _contexto.SaveChanges();
            }
        }
    }
}
