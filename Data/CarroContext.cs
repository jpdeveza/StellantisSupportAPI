using Microsoft.EntityFrameworkCore;
using StellantisSupportAPI.Models;

namespace StellantisSupportAPI.Data
{
    public class CarroContext
    {
        public CarroContext(DbContextOptions<CarroContext> options) : base(options) { }

        public DbSet<ConsumoDesempenho> ConsumoDesempenhos { get; set; }
        public DbSet<PesoDimensoes> PesoDimensoes { get; set; }
        public DbSet<Rodas> Rodas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("YourConnectionStringHere"); // Ajuste a conexão aqui
        }
    }
}
