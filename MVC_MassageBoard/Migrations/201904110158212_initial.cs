namespace MVC_MassageBoard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Testtbs",
                c => new
                    {
                        user = c.String(nullable: false, maxLength: 128),
                        title = c.String(nullable: false),
                        commet = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.user);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Testtbs");
        }
    }
}
