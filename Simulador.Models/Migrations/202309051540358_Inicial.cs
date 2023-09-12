namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.APIToken",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ApiKey = c.Guid(nullable: false),
                        Descripcion = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Persona",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rut = c.Int(),
                        Dv = c.String(),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                        FechaNacimiento = c.DateTime(),
                        EdadReferencia = c.String(),
                        Genero = c.String(),
                        Email = c.String(),
                        Fono = c.String(),
                        Nacionalidad = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persona");
            DropTable("dbo.APIToken");
        }
    }
}
