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
    
    public partial class tbl_goithau_trungthau_files
    {
        public int ID { get; set; }
        public Nullable<int> IDLienket { get; set; }
        public string url_files { get; set; }
        public Nullable<int> type { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        public virtual tbl_giaingan_baocaoquy tbl_giaingan_baocaoquy { get; set; }
    }
}
