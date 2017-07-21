using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolOnline.Models
{
    /*
       1.UserRole
        a)Userroleid - primary, auto-increment
        b)Roleid - 1 is Admin, 2 is Student, 3 is Guardian
        c)RoleDescription - string description of the user role
     */
    public class UserRole
    {
        public int UserRoleID { get; set; }
        public int RoleID { get; set; }
        public string RoleDescription { get; set; }
    }
}