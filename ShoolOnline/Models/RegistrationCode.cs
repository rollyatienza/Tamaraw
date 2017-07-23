using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoolOnline.Models
{
    public class RegistrationCodes
    {
        public int RegistrationCodesID { get; set; }
        public int RegistrationCode { get; set; }
        public string UserID { get; set; }
    }
}