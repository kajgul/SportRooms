using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportRooms.Entities
{
    public class SportRoomDbContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-93NOMA2\\SQLEXPRESS;Database=RestaurantDb;Trusted_Connection=True;";

        public DbSet<Room> Rooms { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //dodać odpowiednie ustawienia dla tych klas
            modelBuilder.Entity<Room>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<League>()
                .Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
                


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}
