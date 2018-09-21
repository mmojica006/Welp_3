using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ContextoAplicacion : DbContext
    {
        public ContextoAplicacion() : base("name=DefaultConnection")
        {
            //Establece la forma que se puede inicializar mi contexto

            //iniciarlizar el archivo de configuracion para administrar las migraciones
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<ContextoAplicacion, Migrations.Configuration>("DefaultConnection"));

            //Testing
           // Database.SetInitializer<ContextoAplicacion>(new CreateDatabaseIfNotExists<ContextoAplicacion>());

        }
        // Twist our database
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Entity<IncSolicEstadoHistorico>()
          .HasIndex(u => u.IncidenteSolicitudId)
          .IsUnique();

          

            base.OnModelCreating(modelBuilder);

          



        }

        public DbSet<HistorialAsignaciones> HistorialAsignaciones { get; set; }
        public DbSet<AreaSucursalResolutor> AreaSucursalResolutor { get; set; }
        public DbSet<Resolutor> Resolutor { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<AreaSucursal> AreaSucursal { get; set; }
        public DbSet<IncidenteSolicitud> IncidenteSolicitud { get;set;}        
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Subcategoria> Subcategoria { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TipoTicket> TipoTicket { get; set; }
        public DbSet<IncSolicEstadoHistorico> IncSolicEstadoHistorico { get; set; }

        public DbSet<Comunicacion> Comunicacion { get; set; }
        public DbSet<Correlacion> Correlacion { get; set; }
        public DbSet<CorrelacionDetalle> CorrelacionDetalle { get; set; }

    }
}
