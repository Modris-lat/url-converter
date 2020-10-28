namespace Data.Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class urlstoragev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UrlContainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LongUrl = c.String(),
                        ShortUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UrlContainers");
        }
    }
}
