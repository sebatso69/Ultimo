namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV15 : DbMigration
    {
        public override void Up()
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
            
            AddColumn("dbo.Condicion_Beneficio", "Condicion_Id", c => c.Int());
            CreateIndex("dbo.Condicion_Beneficio", "Condicion_Id");
            AddForeignKey("dbo.Condicion_Beneficio", "Condicion_Id", "dbo.Condicion", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Condicion_Beneficio", "Condicion_Id", "dbo.Condicion");
            DropIndex("dbo.Condicion_Beneficio", new[] { "Condicion_Id" });
            DropColumn("dbo.Condicion_Beneficio", "Condicion_Id");
            DropTable("dbo.Condicion");
        }
    }
}
