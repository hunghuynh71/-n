//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DON_DAT_HANG
    {
        public DON_DAT_HANG()
        {
            this.CHI_TIET_DON_DAT_HANG = new HashSet<CHI_TIET_DON_DAT_HANG>();
            this.DAT_HANG = new HashSet<DAT_HANG>();
            this.PHIEU_NHAP_HANG = new HashSet<PHIEU_NHAP_HANG>();
        }
    
        public int MADDH { get; set; }
        public System.DateTime NGAYLAP { get; set; }
        public int MANVLAP { get; set; }
        public bool TRANGTHAIXOA { get; set; }
        public bool TRANGTHAIDUYET { get; set; }
    
        public virtual ICollection<CHI_TIET_DON_DAT_HANG> CHI_TIET_DON_DAT_HANG { get; set; }
        public virtual ICollection<DAT_HANG> DAT_HANG { get; set; }
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
        public virtual ICollection<PHIEU_NHAP_HANG> PHIEU_NHAP_HANG { get; set; }
    }
}