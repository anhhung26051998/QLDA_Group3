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
    
    public partial class tbl_cocauTMDT
    {
        public int ID { get; set; }
        public Nullable<int> IdTMDT { get; set; }
        public Nullable<int> Idnguonvon { get; set; }
        public Nullable<decimal> Xaylap { get; set; }
        public Nullable<decimal> Thietbi { get; set; }
        public Nullable<decimal> Tuvan { get; set; }
        public Nullable<decimal> Quanlyduan { get; set; }
        public Nullable<decimal> Khac { get; set; }
        public Nullable<decimal> Duphong { get; set; }
        public Nullable<decimal> Denbugpmb { get; set; }
        public string Mota { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> Landieuchinh { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        public virtual tbl_loaitongmucdautu tbl_loaitongmucdautu { get; set; }
        public virtual tbl_nguonvon tbl_nguonvon { get; set; }
        public virtual tbl_tongmucdautu tbl_tongmucdautu { get; set; }
    }
}
