//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CT_PhieuThue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_PhieuThue()
        {
            this.CT_SDDichVu = new HashSet<CT_SDDichVu>();
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public string MaCTPT { get; set; }
        public string SoPhong { get; set; }
        public string MaPhieuThue { get; set; }
        public Nullable<System.DateTime> NgayBD { get; set; }
        public Nullable<System.DateTime> NgayKT { get; set; }
        public string TinhTrangThue { get; set; }
        public Nullable<decimal> TienPhong { get; set; }
    
        public virtual PhieuThue PhieuThue { get; set; }
        public virtual Phong Phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_SDDichVu> CT_SDDichVu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}