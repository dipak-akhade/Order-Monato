namespace Order_Monato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedoffertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Offer",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        title = c.String(unicode: false),
                        description = c.String(unicode: false),
                        startDate = c.DateTime(nullable: false, precision: 0),
                        endDate = c.DateTime(nullable: false, precision: 0),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Offer");
        }
    }
}
