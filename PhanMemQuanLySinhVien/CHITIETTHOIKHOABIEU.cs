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
    
    public partial class CHITIETTHOIKHOABIEU
    {
        public int IdCTTKB { get; set; }
        public Nullable<int> IdTKB { get; set; }
        public Nullable<int> IdMonHoc { get; set; }
        public string HoVaTenGV { get; set; }
        public Nullable<int> IdBuoi { get; set; }
        public Nullable<int> IdThu { get; set; }
    
        public virtual Buoi Buoi { get; set; }
        public virtual MONHOC MONHOC { get; set; }
        public virtual THU THU { get; set; }
        public virtual THOIKHOABIEU THOIKHOABIEU { get; set; }
    }
}