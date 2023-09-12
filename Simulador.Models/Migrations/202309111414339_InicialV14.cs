namespace Simulador.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialV14 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Condicion_Beneficio", name: "Id_Beneficio_Id", newName: "Beneficio_Id");
            RenameIndex(table: "dbo.Condicion_Beneficio", name: "IX_Id_Beneficio_Id", newName: "IX_Beneficio_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Condicion_Beneficio", name: "IX_Beneficio_Id", newName: "IX_Id_Beneficio_Id");
            RenameColumn(table: "dbo.Condicion_Beneficio", name: "Beneficio_Id", newName: "Id_Beneficio_Id");
        }
    }
}
