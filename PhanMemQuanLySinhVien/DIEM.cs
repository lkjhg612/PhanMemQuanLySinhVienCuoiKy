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
    
    public partial class DIEM
    {
        public int MaSV { get; set; }
        public int MaMH { get; set; }
        public Nullable<double> DiemQuaTrinh { get; set; }
        public Nullable<double> DiemGiuaKy { get; set; }
        public Nullable<double> DiemCuoiKy { get; set; }
    
        public virtual MONHOC MONHOC { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}
