namespace ShoolOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _071817 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleID = c.Int(nullable: false, identity: true),
                        RoleID = c.Int(nullable: false),
                        RoleDescription = c.String(),
                    })
                .PrimaryKey(t => t.UserRoleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRoles");
        }
    }
}
