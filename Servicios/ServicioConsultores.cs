using AccesoDB;
using AccesoDB.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

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
                existente.NombreUsuario = consultor.NombreUsuario;
                existente.Contrasena = consultor.Contrasena;
                _contexto.SaveChanges();
            }
        }

        public void Eliminar(int id)
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
