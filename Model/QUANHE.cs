//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCayGiaPha.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class QUANHE
    {
        public int MaThanhVien1 { get; set; }
        public int MaThanhVien2 { get; set; }
        public int MaLoaiQuanHe { get; set; }
    
        public virtual LOAIQUANHE LOAIQUANHE { get; set; }
        public virtual THANHVIEN THANHVIEN { get; set; }
        public virtual THANHVIEN THANHVIEN1 { get; set; }
    }
}
