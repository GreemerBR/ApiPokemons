using Data.Model;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class PokemonContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5437; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
