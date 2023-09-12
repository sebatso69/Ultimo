namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Beneficio", "Id_Condicion_Beneficio_Id", "dbo.Condicion_Beneficio");
            DropIndex("dbo.Beneficio", new[] { "Id_Condicion_Beneficio_Id" });
            DropTable("dbo.Beneficio");
            DropTable("dbo.Condicion_Beneficio");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Beneficio", "Id_Condicion_Beneficio_Id");
            AddForeignKey("dbo.Beneficio", "Id_Condicion_Beneficio_Id", "dbo.Condicion_Beneficio", "Id");
        }
    }
}
