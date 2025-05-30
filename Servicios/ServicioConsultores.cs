using AccesoDB;
using AccesoDB.Modelos;
using Microsoft.EntityFrameworkCore;

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

        public void AgregarConsultor(Consultor consultor)
        {
            _contexto.Consultores.Add(consultor);
            _contexto.SaveChanges();
        }

        public void Actualizar(Consultor consultorSeleccionado)
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
