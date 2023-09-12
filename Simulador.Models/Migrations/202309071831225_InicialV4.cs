namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV4 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Ley_19");
            DropTable("dbo.Ley_20");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ley_20",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CodSistemaSalud = c.Int(nullable: false),
                        Años_Servicio = c.Int(nullable: false),
                        Edad = c.Int(nullable: false),
                        Edad_Retiro = c.Int(nullable: false),
                        Postulacion1 = c.DateTime(nullable: false),
                        Postulacion2 = c.DateTime(nullable: false),
                        Requisito1 = c.String(),
                        Requisito2 = c.String(),
                        Requisito3 = c.String(),
                        Requisito4 = c.String(),
                        Requisito5 = c.String(),
                        Requisito6 = c.String(),
                        Requisito7 = c.String(),
                        Requisito8 = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ley_19",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Renuncia_Voluntaria = c.Boolean(nullable: false),
                        Periodo = c.Int(nullable: false),
                        Postulacion1 = c.DateTime(nullable: false),
                        Postulacion2 = c.DateTime(nullable: false),
                        Renuncia1 = c.DateTime(),
                        Renuncia2 = c.DateTime(),
                        Requisito1 = c.String(),
                        Requisito2 = c.String(),
                        Requisito3 = c.String(),
                        Requisito4 = c.String(),
                        Requisito5 = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
