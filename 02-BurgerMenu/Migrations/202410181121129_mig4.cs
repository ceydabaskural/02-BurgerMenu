﻿namespace _02_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DealOfTheDay", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DealOfTheDay");
        }
    }
}
