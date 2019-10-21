using AccessOne.Domain.Models;
using AccessOne.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace AccessOne.Infra.Data.Context
{
    public class AccessOneContext : DbContext
    {
        private readonly IHostEnvironment _env;

        public AccessOneContext(IHostEnvironment env)
        {
            _env = env;
        }

        public DbSet<Computador> Computadores { get; set; }
        public DbSet<Comando> Comandos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();


            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            //optionsBuilder.UseSqlServer("Server=tcp:instituto.database.windows.net,1433;Initial Catalog=instituto;Persist Security Info=False;User ID={your_username};Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Computador>(new ComputadorMap().Configure);
            modelBuilder.Entity<Comando>(new ComandoMap().Configure);
            modelBuilder.Entity<Grupo>(new GrupoMap().Configure);
        }
    }
}