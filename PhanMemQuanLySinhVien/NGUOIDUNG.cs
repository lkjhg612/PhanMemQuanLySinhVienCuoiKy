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
    
    public partial class NGUOIDUNG
    {
        public int ID_ND { get; set; }
        public string TenNguoiDung { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public Nullable<int> ID_Quyen { get; set; }
        public Nullable<int> MaSV { get; set; }
    
        public virtual QUYEN QUYEN { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
