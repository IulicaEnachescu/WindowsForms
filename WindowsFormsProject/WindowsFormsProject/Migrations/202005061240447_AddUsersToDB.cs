namespace WindowsFormsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersToDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Nume = c.String(),
                        Prenume = c.String(),
                        Parola = c.String(),
                        UserTypeId = c.Int(nullable: false),
                        AddressId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.UserTypeId)
                .Index(t => t.AddressId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropForeignKey("dbo.Users", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "AddressId" });
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropTable("dbo.Users");
        }
    }
}
