using Microsoft.EntityFrameworkCore;
using AccesoDB.Modelos;

namespace AccesoDB
{
    public class ContextoDb : DbContext
    {
        public ContextoDb(DbContextOptions<ContextoDb> options) : base(options)
        {
            
        }

        //Tablas, sus columnas se mapean a partir de los modelos en AccesoDB/Modelos
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Caso> Casos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<DocumentoElectronico> DocumentosElectronicos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}