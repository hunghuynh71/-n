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
    
    public partial class TAI_KHOAN
    {
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string LOAITAIKHOAN { get; set; }
        public bool TRANGTHAIXOA { get; set; }
        public int MANV { get; set; }
    
        public virtual NHAN_VIEN NHAN_VIEN { get; set; }
    }
}