using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Wine> Wines { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Cata> Catas { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User luis = new User()
            {
                Id = 1,
                Username = "luisito",
                Password = "luiselmejor"
            };

            modelBuilder.Entity<User>().HasData(
                luis);

            Wine vinoDePrueba = new Wine()
            {
                Id = 1,
                Name = "PatadaAlHigado",
                Variety = "Cabernet",
                Year = 1930,
                Region = "Mendoza",
                Stock = 1,
                CreatedAt = DateTime.UtcNow
            };

            modelBuilder.Entity<Wine>().HasData(
                vinoDePrueba);

                    {
            modelBuilder.Entity<Cata>()
                .HasMany(l => l.ListaDeInvitados)
                .WithMany();
        }

            base.OnModelCreating(modelBuilder);
        }

    }
}
