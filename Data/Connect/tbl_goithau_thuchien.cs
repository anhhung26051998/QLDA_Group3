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
    
    public partial class tbl_goithau_thuchien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_goithau_thuchien()
        {
            this.tbl_congtrinh_hangmuc = new HashSet<tbl_congtrinh_hangmuc>();
        }
    
        public int ID { get; set; }
        public Nullable<int> Idgoithau_kehoachlc { get; set; }
        public Nullable<System.DateTime> Timebaocao { get; set; }
        public string Noidungbaocao { get; set; }
        public string Khokhan { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_congtrinh_hangmuc> tbl_congtrinh_hangmuc { get; set; }
        public virtual tbl_goithau_kehoachlc tbl_goithau_kehoachlc { get; set; }
    }
}
