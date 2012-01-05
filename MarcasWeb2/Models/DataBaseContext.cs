using System.Data.Entity;

namespace MarcasWeb2.Models
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pais> Paises { get; set; }
    }
}