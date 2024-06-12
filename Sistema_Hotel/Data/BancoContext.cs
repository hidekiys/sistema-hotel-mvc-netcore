using Microsoft.EntityFrameworkCore;
using Sistema_Hotel.Data.Map;
using Sistema_Hotel.Models;
using System.Reflection.Metadata;
namespace Sistema_Hotel.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuartoMap());
            modelBuilder.ApplyConfiguration(new HospedeMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<QuartoModel> Quartos { get; set; }
        public DbSet<HospedeModel> Hospedes { get; set; }


    }
}
