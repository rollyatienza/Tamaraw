namespace ShoolOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.RegistrationCodes",
            //    c => new
            //        {
            //            RegistrationCodesID = c.Int(nullable: false, identity: true),
            //            RegistrationCode = c.Int(nullable: false),
            //            UserID = c.String(),
            //        })
            //    .PrimaryKey(t => t.RegistrationCodesID);
            
            CreateTable(
                "dbo.SO_User",
                c => new
                    {
                        SO_UserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        password = c.String(),
                        passwordsalt = c.String(),
                        RoleID = c.Int(nullable: false),
                        emailaddress = c.String(),
                        registrationcode = c.String(),
                        IsOnline = c.Boolean(),
                        IsPaid = c.Boolean(),
                        SubscriptionTypeID = c.Int(),
                        PaidDate = c.DateTime(),
                        SubscriptionEndDate = c.DateTime(),
                        AmountPaid = c.Int(),
                    })
                .PrimaryKey(t => t.SO_UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SO_User");
            //DropTable("dbo.RegistrationCodes");
        }
    }
}
