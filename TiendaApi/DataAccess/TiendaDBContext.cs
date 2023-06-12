using Microsoft.EntityFrameworkCore;
using TiendaApi.Models;

namespace TiendaApi.DataAccess
{
    public class TiendaDBContext: DbContext
    {
        public TiendaDBContext(DbContextOptions<TiendaDBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Sale> Sales { get; set; }

/*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionString"); // Reemplaza "YourConnectionString" con la cadena de conexión de tu base de datos
        }
*/
    }
}
