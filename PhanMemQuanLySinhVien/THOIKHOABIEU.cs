//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhanMemQuanLySinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class THOIKHOABIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public THOIKHOABIEU()
        {
            this.CHITIETTHOIKHOABIEUx = new HashSet<CHITIETTHOIKHOABIEU>();
        }
    
        public int IdTKB { get; set; }
        public Nullable<int> IdLop { get; set; }
        public Nullable<int> IdKhoa { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTHOIKHOABIEU> CHITIETTHOIKHOABIEUx { get; set; }
        public virtual KHOA KHOA { get; set; }
        public virtual LOP LOP { get; set; }
    }
}