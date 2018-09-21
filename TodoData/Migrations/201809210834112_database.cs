namespace TodoData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Message = c.String(),
                        DateGenerated = c.DateTime(nullable: false),
                        DateUpdated = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        FinishDate = c.DateTime(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "UserId", "dbo.Users");
            DropIndex("dbo.Todoes", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Todoes");
        }
    }
}
