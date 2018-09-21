namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Area",
                c => new
                    {
                        AreaId = c.Int(nullable: false, identity: true),
                        NnombreArea = c.String(),
                        Descripcion = c.String(),
                        orden = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AreaId);
            
            CreateTable(
                "dbo.AreaSucursal",
                c => new
                    {
                        AreaSucursalId = c.Int(nullable: false, identity: true),
                        SucursalId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AreaSucursalId)
                .ForeignKey("dbo.Area", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Sucursal", t => t.SucursalId, cascadeDelete: true)
                .Index(t => t.SucursalId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.Sucursal",
                c => new
                    {
                        SucursalId = c.Int(nullable: false, identity: true),
                        NombreSucursal = c.String(),
                    })
                .PrimaryKey(t => t.SucursalId);
            
            CreateTable(
                "dbo.AreaSucursalResolutor",
                c => new
                    {
                        AreaSucursalResolutorId = c.Int(nullable: false, identity: true),
                        ResolutorId = c.Int(nullable: false),
                        AreaSucursalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AreaSucursalResolutorId)
                .ForeignKey("dbo.AreaSucursal", t => t.AreaSucursalId, cascadeDelete: true)
                .ForeignKey("dbo.Resolutor", t => t.ResolutorId, cascadeDelete: true)
                .Index(t => t.ResolutorId)
                .Index(t => t.AreaSucursalId);
            
            CreateTable(
                "dbo.Resolutor",
                c => new
                    {
                        ResolutorId = c.Int(nullable: false, identity: true),
                        ApellidoPaterno = c.String(),
                        apellidoMaterno = c.String(),
                        Nombres = c.String(),
                        NombreUsuario = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.ResolutorId);
            
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        CategoriaNombre = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Subcategoria",
                c => new
                    {
                        SubcategoriaId = c.Int(nullable: false, identity: true),
                        SubcategoriaNombre = c.String(),
                        UsuarioGestion = c.String(),
                        CategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.SubcategoriaId)
                .ForeignKey("dbo.Categoria", t => t.CategoriaId)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.IncidenteSolicitud",
                c => new
                    {
                        IncidenteSolicitudId = c.Int(nullable: false, identity: true),
                        SubcategoriaId = c.Int(),
                        PersonaSoporte = c.String(),
                        PersonaAsignacion = c.String(),
                        FechaAsignacion = c.DateTime(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        FechaFinalizacionEstimada = c.DateTime(nullable: false),
                        FechaSolucion = c.DateTime(nullable: false),
                        SolucionAplicada = c.String(),
                        Rating = c.Int(nullable: false),
                        MotivoRetraso = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.IncidenteSolicitudId)
                .ForeignKey("dbo.Estado", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.Subcategoria", t => t.SubcategoriaId)
                .Index(t => t.SubcategoriaId)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        NombreEstado = c.String(),
                        DescripcionEstado = c.String(),
                        Abreviatura = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Comunicacion",
                c => new
                    {
                        ComunicacionId = c.Int(nullable: false, identity: true),
                        IncidenteSolicitudId = c.Int(nullable: false),
                        Remitente = c.String(),
                        Mensaje = c.String(),
                        FechaEnvio = c.DateTime(nullable: false),
                        Leido = c.Boolean(nullable: false),
                        FechaLectura = c.DateTime(nullable: false),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.ComunicacionId)
                .ForeignKey("dbo.IncidenteSolicitud", t => t.IncidenteSolicitudId, cascadeDelete: true)
                .Index(t => t.IncidenteSolicitudId);
            
            CreateTable(
                "dbo.Correlacion",
                c => new
                    {
                        CorrelacionId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.CorrelacionId);
            
            CreateTable(
                "dbo.CorrelacionDetalle",
                c => new
                    {
                        CorrelacionDetalleId = c.Int(nullable: false, identity: true),
                        CorrelacionId = c.Int(nullable: false),
                        IncidenteSolicitudId = c.Int(nullable: false),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.CorrelacionDetalleId)
                .ForeignKey("dbo.Correlacion", t => t.CorrelacionId, cascadeDelete: true)
                .ForeignKey("dbo.IncidenteSolicitud", t => t.IncidenteSolicitudId, cascadeDelete: true)
                .Index(t => t.CorrelacionId)
                .Index(t => t.IncidenteSolicitudId);
            
            CreateTable(
                "dbo.HistorialAsignaciones",
                c => new
                    {
                        HistorialAsignacionesId = c.Int(nullable: false, identity: true),
                        IncidenteSolicitudId = c.Int(nullable: false),
                        PersonaSoporte = c.String(),
                        MotivoReasignacion = c.String(),
                        FechaReasignacion = c.DateTime(nullable: false),
                        PersonaRealizaReasignacion = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.HistorialAsignacionesId)
                .ForeignKey("dbo.IncidenteSolicitud", t => t.IncidenteSolicitudId, cascadeDelete: true)
                .Index(t => t.IncidenteSolicitudId);
            
            CreateTable(
                "dbo.IncSolicEstadoHistorico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncidenteSolicitudId = c.Int(nullable: false),
                        EstadoId = c.Int(nullable: false),
                        FechaHoraEstado = c.DateTime(nullable: false),
                        ComentariosEstado = c.String(),
                        UsuarioGestion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estado", t => t.EstadoId, cascadeDelete: true)
                .Index(t => t.IncidenteSolicitudId, unique: true)
                .Index(t => t.EstadoId);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        SubcategoriaId = c.Int(),
                        Encabezado = c.String(),
                        Prioridad = c.String(),
                        DescripcionPeticion = c.String(),
                        FechaEntradaTicket = c.DateTime(nullable: false),
                        UsuarioPeticion = c.String(),
                        TipoTicketId = c.Int(nullable: false),
                        archivosURL = c.String(),
                        TieneAdjuntos = c.Boolean(nullable: false),
                        Eliminado = c.Boolean(nullable: false),
                        UsuarioGestion = c.String(),
                        SucursalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId)
                .ForeignKey("dbo.Subcategoria", t => t.SubcategoriaId)
                .ForeignKey("dbo.Sucursal", t => t.SucursalId, cascadeDelete: true)
                .ForeignKey("dbo.TipoTicket", t => t.TipoTicketId, cascadeDelete: true)
                .Index(t => t.SubcategoriaId)
                .Index(t => t.TipoTicketId)
                .Index(t => t.SucursalId);
            
            CreateTable(
                "dbo.TipoTicket",
                c => new
                    {
                        TipoTicketId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.TipoTicketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ticket", "TipoTicketId", "dbo.TipoTicket");
            DropForeignKey("dbo.Ticket", "SucursalId", "dbo.Sucursal");
            DropForeignKey("dbo.Ticket", "SubcategoriaId", "dbo.Subcategoria");
            DropForeignKey("dbo.IncSolicEstadoHistorico", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.HistorialAsignaciones", "IncidenteSolicitudId", "dbo.IncidenteSolicitud");
            DropForeignKey("dbo.CorrelacionDetalle", "IncidenteSolicitudId", "dbo.IncidenteSolicitud");
            DropForeignKey("dbo.CorrelacionDetalle", "CorrelacionId", "dbo.Correlacion");
            DropForeignKey("dbo.Comunicacion", "IncidenteSolicitudId", "dbo.IncidenteSolicitud");
            DropForeignKey("dbo.IncidenteSolicitud", "SubcategoriaId", "dbo.Subcategoria");
            DropForeignKey("dbo.IncidenteSolicitud", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.Subcategoria", "CategoriaId", "dbo.Categoria");
            DropForeignKey("dbo.AreaSucursalResolutor", "ResolutorId", "dbo.Resolutor");
            DropForeignKey("dbo.AreaSucursalResolutor", "AreaSucursalId", "dbo.AreaSucursal");
            DropForeignKey("dbo.AreaSucursal", "SucursalId", "dbo.Sucursal");
            DropForeignKey("dbo.AreaSucursal", "AreaId", "dbo.Area");
            DropIndex("dbo.Ticket", new[] { "SucursalId" });
            DropIndex("dbo.Ticket", new[] { "TipoTicketId" });
            DropIndex("dbo.Ticket", new[] { "SubcategoriaId" });
            DropIndex("dbo.IncSolicEstadoHistorico", new[] { "EstadoId" });
            DropIndex("dbo.IncSolicEstadoHistorico", new[] { "IncidenteSolicitudId" });
            DropIndex("dbo.HistorialAsignaciones", new[] { "IncidenteSolicitudId" });
            DropIndex("dbo.CorrelacionDetalle", new[] { "IncidenteSolicitudId" });
            DropIndex("dbo.CorrelacionDetalle", new[] { "CorrelacionId" });
            DropIndex("dbo.Comunicacion", new[] { "IncidenteSolicitudId" });
            DropIndex("dbo.IncidenteSolicitud", new[] { "EstadoId" });
            DropIndex("dbo.IncidenteSolicitud", new[] { "SubcategoriaId" });
            DropIndex("dbo.Subcategoria", new[] { "CategoriaId" });
            DropIndex("dbo.AreaSucursalResolutor", new[] { "AreaSucursalId" });
            DropIndex("dbo.AreaSucursalResolutor", new[] { "ResolutorId" });
            DropIndex("dbo.AreaSucursal", new[] { "AreaId" });
            DropIndex("dbo.AreaSucursal", new[] { "SucursalId" });
            DropTable("dbo.TipoTicket");
            DropTable("dbo.Ticket");
            DropTable("dbo.IncSolicEstadoHistorico");
            DropTable("dbo.HistorialAsignaciones");
            DropTable("dbo.CorrelacionDetalle");
            DropTable("dbo.Correlacion");
            DropTable("dbo.Comunicacion");
            DropTable("dbo.Estado");
            DropTable("dbo.IncidenteSolicitud");
            DropTable("dbo.Subcategoria");
            DropTable("dbo.Categoria");
            DropTable("dbo.Resolutor");
            DropTable("dbo.AreaSucursalResolutor");
            DropTable("dbo.Sucursal");
            DropTable("dbo.AreaSucursal");
            DropTable("dbo.Area");
        }
    }
}
