namespace ShoolOnline.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ShoolOnline.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<ShoolOnline.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoolOnline.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.SO_Users.AddOrUpdate(
                p => p.FirstName,
                new SO_User
                {            
                    FirstName = "System",
                    LastName = "Admin",
                    Username = "administrator",
                    password = "safadfasdf",
                    passwordsalt ="1sdsdf",
                    RoleID = 1,
                    emailaddress = "rollyatienza@gmail.com",
                    registrationcode = "ADMIN1",
                    IsOnline = false,
                    IsPaid = null,
                    SubscriptionTypeID  = null,
                    PaidDate = null,
                    SubscriptionEndDate = null,
                    AmountPaid = null
                 },
                new SO_User
                {
                    FirstName = "Rolly",
                    LastName = "Atienza",
                    Username = "blacksun",
                    password = "safadfasdf",
                    passwordsalt = "1sdsdf",
                    RoleID = 1,
                    emailaddress = "rollyatienza@gmail.com",
                    registrationcode = "ADMIN1",
                    IsOnline = false,
                    IsPaid = null,
                    SubscriptionTypeID = null,
                    PaidDate = null,
                    SubscriptionEndDate = null,
                    AmountPaid = null
                }
                );
            context.SubscriptionTypes.AddOrUpdate(
                p => p.SubscriptionName,
                new SubscriptionType
                {
                    SubscriptionName = "Monthly",
                    SubscriptionAmount = 100,
                    Description = "Monthly subscription."
                },
                new SubscriptionType
                {
                    SubscriptionName = "Quarter",
                    SubscriptionAmount = 250,
                    Description = "3 months subscription."
                },
                new SubscriptionType
                {
                    SubscriptionName = "SixMonths",
                    SubscriptionAmount = 500,
                    Description = "6 months subscription."
                }
                );

            context.UserRoles.AddOrUpdate(
                p => p.RoleDescription,
                new UserRole
                {   
                    RoleID = 1,
                    RoleDescription = "Admin"
                },
                new UserRole
                {
                    RoleID = 2,
                    RoleDescription = "Student"
                },
                new UserRole
                {
                    RoleID = 3,
                    RoleDescription = "Guardian"
                }
                );

            context.Contacts.AddOrUpdate(p => p.Name,
        new Contact
        {
            Name = "Debra Garcia",
            Address = "1234 Main St",
            City = "Redmond",
            State = "WA",
            Zip = "10999",
            Email = "debra@example.com",
            Twitter = "debra_example"
        },
         new Contact
         {
             Name = "Thorsten Weinrich",
             Address = "5678 1st Ave W",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "thorsten@example.com",
             Twitter = "thorsten_example"
         },
         new Contact
         {
             Name = "Yuhong Li",
             Address = "9012 State st",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "yuhong@example.com",
             Twitter = "yuhong_example"
         },
         new Contact
         {
             Name = "Jon Orton",
             Address = "3456 Maple St",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "jon@example.com",
             Twitter = "jon_example"
         },
         new Contact
         {
             Name = "Diliana Alexieva-Bosseva",
             Address = "7890 2nd Ave E",
             City = "Redmond",
             State = "WA",
             Zip = "10999",
             Email = "diliana@example.com",
             Twitter = "diliana_example"
         }
         );
        }
    }
}
