namespace _02_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {

        //Up() : Update in metodu
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        //Down: İşlemi iptal etme butonu
        public override void Down()
        {
            DropTable("dbo.Admins");
        }
    }
}
