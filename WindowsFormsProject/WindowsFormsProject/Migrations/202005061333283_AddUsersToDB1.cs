namespace WindowsFormsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersToDB1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.Users", "UserName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "UserName" });
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
