namespace WindowsFormsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUserType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO UserTypes (Name) VALUES ('Admin');");
            Sql("INSERT INTO UserTypes (Name) VALUES ('Client');");
        }
        
        public override void Down()
        {
            //we can put some deleted statements in here
        }
    }
}
