using Microsoft.EntityFrameworkCore;
using SG_VacyPer.Models;

namespace SG_VacyPer.AppData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)   { }
        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Vacaciones> Vacaciones { get; set; }
        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Calendario> Calendario { get; set; }
        public DbSet<SolicitudVacaciones> SolicitudVacaciones { get; set; }
        public DbSet<SolicitudPermisos> SolicitudPermisos { get; set; }
        // Para crear otros indices que no son primarios
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Indices de la tabla de: EMPLEADOS
            builder.Entity<Empleados>()
                .HasIndex(u => u.DocIdentidad)
                .IsUnique();
            builder.Entity<Empleados>()
                .HasIndex(u => u.NombreCompleto);
            // Indices de la tabla de: CALENDARIO
            builder.Entity<Calendario>()
                .HasIndex(u => u.Comienzo);
            // Indices de la tabla de: PERMISOS
            builder.Entity<Permisos>()
                .HasIndex(u => u.Descripcion);
            // Indices de la tabla de: SOLICITUD VACACIONES
            builder.Entity<SolicitudVacaciones>()
                .HasIndex(u => u.DocIdentidad);
            builder.Entity<SolicitudVacaciones>()
                .HasIndex(u => u.Estado);
            // Indices de la tabla de: SOLICITUD PERMISOS
            builder.Entity<SolicitudPermisos>()
                .HasIndex(u => u.DocIdentidad);
            builder.Entity<SolicitudPermisos>()
                .HasIndex(u => u.FechaSolicitud);
            builder.Entity<SolicitudPermisos>()
                .HasIndex(u => u.FechaComienzo);
            builder.Entity<SolicitudPermisos>()
                .HasIndex(u => u.Estado);
        }
    }
}
