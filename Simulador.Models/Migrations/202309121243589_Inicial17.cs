namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Simulacion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cumple = c.Boolean(nullable: false),
                        Fecha_Consulta = c.DateTime(nullable: false),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Simulacion");
        }
    }
}
