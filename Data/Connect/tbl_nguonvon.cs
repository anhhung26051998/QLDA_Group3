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
    
    public partial class tbl_nguonvon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_nguonvon()
        {
            this.tbl_cocauTMDT = new HashSet<tbl_cocauTMDT>();
            this.tbl_duan = new HashSet<tbl_duan>();
            this.tbl_phanbovon = new HashSet<tbl_phanbovon>();
        }
    
        public int ID { get; set; }
        public string Manguonvon { get; set; }
        public string Tennguonvon { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cocauTMDT> tbl_cocauTMDT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_duan> tbl_duan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_phanbovon> tbl_phanbovon { get; set; }
    }
}