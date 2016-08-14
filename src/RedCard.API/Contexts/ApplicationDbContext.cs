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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigurePlayer();
        }

        public DbSet<Player> Players { get; set; }
    }

    public static class DbContextExtensionMethods
    {
        public static ModelBuilder ConfigurePlayer(this ModelBuilder modelBuilder)
        {
            var playerBuilder = modelBuilder.Entity<Player>();

            playerBuilder.HasKey(player => player.Id);

            // Ensure player name is unique
            playerBuilder.HasAlternateKey(player => player.Name);

            playerBuilder
                .Property(player => player.Country)
                .IsRequired();

            playerBuilder
                .Property(player => player.League)
                .IsRequired();

            playerBuilder
                .Property(player => player.Team)
                .IsRequired();

            playerBuilder
                .Property(player => player.Position)
                .IsRequired();

            return modelBuilder;
        }
    }
}
