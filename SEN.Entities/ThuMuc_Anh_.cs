//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEN.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThuMuc_Anh_
    {
        public int TMAnhId { get; set; }
        public string TenThuMuc { get; set; }
        public int ThanhVienId { get; set; }
        public string KieuDuLieu { get; set; }
        public int KichThuoc { get; set; }
        public int ThuTu { get; set; }
        public System.DateTime ThoiGian { get; set; }
        public string ThuMuc { get; set; }
    
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
