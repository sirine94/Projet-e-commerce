namespace Projet_Turquoise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        reference = c.String(),
                        nom = c.String(),
                        genre = c.String(),
                        categorie = c.String(),
                        prix = c.Double(nullable: false),
                        nombre = c.Int(nullable: false),
                        couleur = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Articles");
        }
    }
}
