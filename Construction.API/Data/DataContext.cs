using Construction.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Construction.API.Data
{
    public class DataContext:DbContext  
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { 
        
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
        }



    }
}
