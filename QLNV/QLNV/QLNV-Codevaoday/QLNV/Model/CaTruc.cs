//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CaTruc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CaTruc()
        {
            this.PhanCong = new HashSet<PhanCong>();
        }
    
        public int CaTrucID { get; set; }
        public Nullable<int> YeuCauID { get; set; }
        public Nullable<System.DateTime> BatDau { get; set; }
        public Nullable<System.DateTime> KetThuc { get; set; }
        public string TenCa { get; set; }
    
        public virtual YeuCau YeuCau { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanCong> PhanCong { get; set; }
    }
}
