namespace _02_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        SubscriberId = c.Int(nullable: false, identity: true),
                        SubscriberEmail = c.String(),
                    })
                .PrimaryKey(t => t.SubscriberId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscribers");
        }
    }
}
