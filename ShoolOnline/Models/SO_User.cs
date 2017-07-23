using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolOnline.Models
{
    //a)Userid - primary, auto-increment
    //b)Firstname
    //c)Lastname
    //d)Username - <firstname>.<lastname> 
    //e)Password
    //f)RoleID - UserRole.Roleid
    //g)Emailaddress
    //h)RegistrationCode
    //i)IsOnline - is the user online?
    //j)IsPaid - is the user already made the payment?
    //k)SubscriptionType - type of subscriptions(see SubscriptionType table for details
    //l)PaidDate - payment date
    //m)SubscriptionDateEnd - End of subscription date
    //AmountPaid - amount paid
    public class SO_User
    {
        public int SO_UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string password { get; set; } 
        public string passwordsalt { get; set; }
        public int RoleID { get; set; }
        public string emailaddress { get; set; }
        public string registrationcode { get; set; }
        public bool? IsOnline { get; set; }
        public bool? IsPaid { get; set; }
        public int? SubscriptionTypeID { get; set; }
        public DateTime? PaidDate { get; set; }
        public DateTime? SubscriptionEndDate { get; set; }
        public int? AmountPaid { get; set; }
    }
}