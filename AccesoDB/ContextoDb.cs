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
    }
}