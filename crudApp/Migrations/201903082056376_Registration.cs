namespace crudApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRegistrations",
                c => new
                    {
                        iUserId = c.Int(nullable: false, identity: true),
                        sFirstName = c.String(nullable: false),
                        sLastName = c.String(nullable: false),
                        sGender = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.iUserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRegistrations");
        }
    }
}
