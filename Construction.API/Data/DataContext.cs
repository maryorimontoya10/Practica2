using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Construction.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Data
{
    public class DataContext:IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {

            Database.EnsureCreated();
        }

        public DbSet<Equipo>Equipos { get; set; }
        public DbSet<Maquinaria>Maquinarias { get; set; }
        public DbSet<Material>Materiales { get; set; }
        public DbSet<Presupuesto>Presupuestos { get; set; }
        public DbSet<Proyecto>Proyectos { get; set; }
        public DbSet<Tarea>Tareas { get; set; }
        public DbSet<ProyectoEquipo> ProyectosEquipos { get; set; }
        public DbSet<TareaMaterial> TareasMateriales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Presupuesto>()
              .Property(p => p.PresupuestoManoObra)
              .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Presupuesto>()
                .Property(p => p.PresupuestoMaquinaria)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Presupuesto>()
              .Property(p => p.PresupuestoMateriales)
              .HasColumnType("decimal(18, 2)");
        }



    }
}
