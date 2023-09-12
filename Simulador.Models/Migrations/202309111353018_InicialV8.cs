namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV8 : DbMigration
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
                        Condicion_Beneficio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Condicion_Beneficio", t => t.Condicion_Beneficio_Id)
                .Index(t => t.Condicion_Beneficio_Id);
            
            CreateTable(
                "dbo.Condicion",
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
            DropForeignKey("dbo.Beneficio", "Condicion_Beneficio_Id", "dbo.Condicion_Beneficio");
            DropIndex("dbo.Beneficio", new[] { "Condicion_Beneficio_Id" });
            DropTable("dbo.Condicion");
            DropTable("dbo.Beneficio");
        }
    }
}
