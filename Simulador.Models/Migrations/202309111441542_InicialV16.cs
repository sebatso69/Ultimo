namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Simulacion_Cond",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cumple_Condicion = c.Boolean(nullable: false),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                        Condicion_Beneficio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Condicion_Beneficio", t => t.Condicion_Beneficio_Id)
                .Index(t => t.Condicion_Beneficio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Simulacion_Cond", "Condicion_Beneficio_Id", "dbo.Condicion_Beneficio");
            DropIndex("dbo.Simulacion_Cond", new[] { "Condicion_Beneficio_Id" });
            DropTable("dbo.Simulacion_Cond");
        }
    }
}
