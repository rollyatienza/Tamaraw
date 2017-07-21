namespace ShoolOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class subscriptionType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscriptionTypes",
                c => new
                    {
                        SubscriptionTypeID = c.Int(nullable: false, identity: true),
                        SubscriptionName = c.String(),
                        SubscriptionAmount = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionTypeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SubscriptionTypes");
        }
    }
}
