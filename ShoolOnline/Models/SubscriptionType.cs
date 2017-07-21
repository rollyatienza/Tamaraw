using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolOnline.Models
{
    //3.SubscriptionType - app is subscription based.Subscription and amount is identified as the following:
    //    i.Monthly : 100
    //    ii.Quarter : 250
    //    iii.SixMonths : 500
    //    b)SubscriptionTypeID
    //    c)SubscriptionName
    //    d)SubscriptionAmount
    public class SubscriptionType
    {
        public int SubscriptionTypeID { get; set; }
        public string SubscriptionName { get; set; }
        public int SubscriptionAmount { get; set; }
        public string Description { get; set; }
    }
}