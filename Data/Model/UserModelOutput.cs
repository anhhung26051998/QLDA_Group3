using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Model
{
    public class UserModelOutput
    {
        public int User_Id { get; set; }
        public Nullable<int> IdRole { get; set; }
        public Nullable<int> IdChudautu { get; set; }
        public string Username { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<bool> Inactive { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Initial { get; set; }
        public string Mail { get; set; }
        public string RoleName { get; set; }
    }
}