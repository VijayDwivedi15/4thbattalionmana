namespace Battalion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fornew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserContacts",
                c => new
                    {
                        ContactID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserContacts");
        }
    }
}
