namespace _02_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "ImageUrl");
        }
    }
}
