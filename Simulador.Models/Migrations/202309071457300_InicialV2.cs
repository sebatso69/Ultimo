namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.User");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Creado = c.DateTime(nullable: false),
                        Modificado = c.DateTime(),
                        Activo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
