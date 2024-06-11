using Microsoft.EntityFrameworkCore;
using Sistema_Hotel.Models;
namespace Sistema_Hotel.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        public DbSet<QuartoModel> Quartos {  get; set; }
    }
}
