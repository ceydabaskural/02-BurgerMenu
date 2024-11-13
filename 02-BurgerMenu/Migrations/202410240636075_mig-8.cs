namespace _02_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
