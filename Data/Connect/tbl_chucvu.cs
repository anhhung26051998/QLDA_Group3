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
    
    public partial class tbl_chucvu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_chucvu()
        {
            this.tbl_cocautochucCDT = new HashSet<tbl_cocautochucCDT>();
        }
    
        public int ID { get; set; }
        public string Machucvu { get; set; }
        public string Tenchucvu { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cocautochucCDT> tbl_cocautochucCDT { get; set; }
    }
}
