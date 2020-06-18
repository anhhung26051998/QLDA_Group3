using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Connect
{
    public class LoginModelOutput
    {
        public string token { get; set; }
        public int UserId { get; set; }
        public int? Role { get; set; }
        public Nullable<int> IdCDT { get; set; }
    }
}