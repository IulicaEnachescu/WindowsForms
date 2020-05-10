namespace WindowsFormsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBooksToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AuthorId = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        Price = c.Decimal(precision: 18, scale: 2),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .Index(t => t.AuthorId)
                .Index(t => t.Author_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_Id" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropIndex("dbo.Authors", new[] { "Book_Id" });
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
