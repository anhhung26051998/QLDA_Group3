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
    
    public partial class tbl_loaihopdong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_loaihopdong()
        {
            this.tbl_goithau_kehoachlc = new HashSet<tbl_goithau_kehoachlc>();
            this.tbl_goithau_loaihopdong = new HashSet<tbl_goithau_loaihopdong>();
            this.tbl_goithau_trungthau_loaihopdong = new HashSet<tbl_goithau_trungthau_loaihopdong>();
        }
    
        public int ID { get; set; }
        public string Maloaihopdong { get; set; }
        public string Tenloaihopdong { get; set; }
        public string Nguoitao { get; set; }
        public Nullable<System.DateTime> Ngaytao { get; set; }
        public string Nguoisua { get; set; }
        public Nullable<System.DateTime> Ngaysua { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_goithau_kehoachlc> tbl_goithau_kehoachlc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_goithau_loaihopdong> tbl_goithau_loaihopdong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_goithau_trungthau_loaihopdong> tbl_goithau_trungthau_loaihopdong { get; set; }
    }
}
