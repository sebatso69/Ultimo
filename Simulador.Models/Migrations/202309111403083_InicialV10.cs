namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV10 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Beneficio", "Condicion_Beneficio_Id", "dbo.Condicion_Beneficio");
            DropForeignKey("dbo.Condicion_Beneficio", "Id_Beneficio_Id", "dbo.Beneficio");
            DropForeignKey("dbo.Condicion_Beneficio", "Beneficio_Id", "dbo.Beneficio");
            DropIndex("dbo.Beneficio", new[] { "Condicion_Beneficio_Id" });
            DropIndex("dbo.Condicion_Beneficio", new[] { "Id_Beneficio_Id" });
            DropIndex("dbo.Condicion_Beneficio", new[] { "Beneficio_Id" });
            DropTable("dbo.Beneficio");
            DropTable("dbo.Condicion_Beneficio");
            DropTable("dbo.Condicion");
        }
        
        public override void Down()
        {
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
            
            CreateTable(
                "dbo.Condicion_Beneficio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                        Id_Beneficio_Id = c.Int(),
                        Beneficio_Id = c.Int(),
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
                        Condicion_Beneficio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Condicion_Beneficio", "Beneficio_Id");
            CreateIndex("dbo.Condicion_Beneficio", "Id_Beneficio_Id");
            CreateIndex("dbo.Beneficio", "Condicion_Beneficio_Id");
            AddForeignKey("dbo.Condicion_Beneficio", "Beneficio_Id", "dbo.Beneficio", "Id");
            AddForeignKey("dbo.Condicion_Beneficio", "Id_Beneficio_Id", "dbo.Beneficio", "Id");
            AddForeignKey("dbo.Beneficio", "Condicion_Beneficio_Id", "dbo.Condicion_Beneficio", "Id");
        }
    }
}
