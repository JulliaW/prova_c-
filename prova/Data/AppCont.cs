using Microsoft.EntityFrameworkCore;
using prova.Models;

namespace prova.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
