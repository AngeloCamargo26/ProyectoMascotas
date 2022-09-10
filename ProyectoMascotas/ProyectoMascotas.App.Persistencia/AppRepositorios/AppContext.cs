using Microsoft.EntityFrameworkCore;
using ProyectoMascotas.App.Dominio;

namespace ProyectoMascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Historias_Clinicas> historias_clinicas  {get; set;}
        public DbSet<Mascota> mascotas {get; set;}
        public DbSet<Propietario> propietarios {get; set;}
        public DbSet<Veterinario> veterinarios {get; set;}
        public DbSet<Visitas> visitas {get; set;}
        // implementar todas las clases


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if(!optionBuilder.IsConfigured)
            {
               optionBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoMascotas.Data");
            }
        } 

    }
}