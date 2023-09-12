namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Condicion_Beneficio", "Id_Beneficio_Id", c => c.Int());
            AddColumn("dbo.Condicion_Beneficio", "Beneficio_Id", c => c.Int());
            CreateIndex("dbo.Condicion_Beneficio", "Id_Beneficio_Id");
            CreateIndex("dbo.Condicion_Beneficio", "Beneficio_Id");
            AddForeignKey("dbo.Condicion_Beneficio", "Id_Beneficio_Id", "dbo.Beneficio", "Id");
            AddForeignKey("dbo.Condicion_Beneficio", "Beneficio_Id", "dbo.Beneficio", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Condicion_Beneficio", "Beneficio_Id", "dbo.Beneficio");
            DropForeignKey("dbo.Condicion_Beneficio", "Id_Beneficio_Id", "dbo.Beneficio");
            DropIndex("dbo.Condicion_Beneficio", new[] { "Beneficio_Id" });
            DropIndex("dbo.Condicion_Beneficio", new[] { "Id_Beneficio_Id" });
            DropColumn("dbo.Condicion_Beneficio", "Beneficio_Id");
            DropColumn("dbo.Condicion_Beneficio", "Id_Beneficio_Id");
        }
    }
}
