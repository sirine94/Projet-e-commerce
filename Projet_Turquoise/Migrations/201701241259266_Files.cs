namespace Projet_Turquoise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Files : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        PersonId = c.Int(nullable: false),
                        article_ID = c.Int(),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Articles", t => t.article_ID)
                .Index(t => t.article_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Files", "article_ID", "dbo.Articles");
            DropIndex("dbo.Files", new[] { "article_ID" });
            DropTable("dbo.Files");
        }
    }
}
