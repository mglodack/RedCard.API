using Microsoft.EntityFrameworkCore;
using RedCard.API.Models;

namespace RedCard.API.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=(localdb)\mssqllocaldb;Database=RedCard.Development;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Player> Players { get; set; }
    }
}
