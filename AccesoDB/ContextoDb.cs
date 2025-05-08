using Microsoft.EntityFrameworkCore;
using AccesoDB.Modelos;

namespace AccesoDB
{
    public class ContextoDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = GCAMCDB.db");

        }

        //Tablas, sus columnas se mapean de los modelos en AccesoDB/Modelos, Persona no se mapea
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Caso> Casos { get; set; }
        public DbSet<ClienteNatural> ClienteNaturales { get; set; }
        public DbSet<Consultor> Consultores { get; set; }
        public DbSet<DocumentoElectronico> DocumentosElectronicos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
    }
}