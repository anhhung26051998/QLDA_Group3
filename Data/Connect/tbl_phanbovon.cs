//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data.Connect
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_phanbovon
    {
        public int ID { get; set; }
        public Nullable<int> Maduan { get; set; }
        public Nullable<decimal> Sotienvon { get; set; }
        public string Giaidoansudung { get; set; }
        public string Motavon { get; set; }
        public Nullable<int> Idnguonvon { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        public virtual tbl_nguonvon tbl_nguonvon { get; set; }
    }
}
