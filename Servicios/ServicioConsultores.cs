using AccesoDB;
using AccesoDB.Modelos;

namespace Servicios
{
    public class ServicioConsultores
    {
         private readonly ContextoDb _contexto;

        public ServicioConsultores(ContextoDb contexto)
        {
            _contexto = contexto;
        }
        public List<Consultor> ObtenerTodos()
        {
            return _contexto.Consultores.ToList();
        }

        public void Crear(Consultor consultor)
        {
            _contexto.Consultores.Add(consultor);
            _contexto.SaveChanges();
        }

        public void Actualizar(Consultor consultor)
        {
            var existente = _contexto.Consultores.Find(consultor.Id);
            if (existente != null)
            {
                existente.Nombres = consultor.Nombres;
                existente.Contrasena = consultor.Contrasena;
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
