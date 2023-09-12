namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV6 : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Condicion_Beneficio");
        }
    }
}
