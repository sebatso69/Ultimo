namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV13 : DbMigration
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
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Condicion_Beneficio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                        Id_Beneficio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beneficio", t => t.Id_Beneficio_Id)
                .Index(t => t.Id_Beneficio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Condicion_Beneficio", "Id_Beneficio_Id", "dbo.Beneficio");
            DropIndex("dbo.Condicion_Beneficio", new[] { "Id_Beneficio_Id" });
            DropTable("dbo.Condicion_Beneficio");
            DropTable("dbo.Beneficio");
        }
    }
}
