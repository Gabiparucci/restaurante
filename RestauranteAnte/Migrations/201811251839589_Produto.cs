namespace RestauranteAnte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pedidoes", "PratoID", "dbo.Pratoes");
            DropIndex("dbo.Pedidoes", new[] { "PratoID" });
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Pratoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        PratoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Valor = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PratoID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PratoID = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        vTotal = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.Pedidoes", "PratoID");
            AddForeignKey("dbo.Pedidoes", "PratoID", "dbo.Pratoes", "PratoID", cascadeDelete: true);
        }
    }
}
