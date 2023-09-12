namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                        Id_Condicion_Beneficio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Condicion_Beneficio", t => t.Id_Condicion_Beneficio_Id)
                .Index(t => t.Id_Condicion_Beneficio_Id);
            
            CreateTable(
                "dbo.Condicion_Beneficio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beneficio", "Id_Condicion_Beneficio_Id", "dbo.Condicion_Beneficio");
            DropIndex("dbo.Beneficio", new[] { "Id_Condicion_Beneficio_Id" });
            DropTable("dbo.Condicion_Beneficio");
            DropTable("dbo.Beneficio");
        }
    }
}
