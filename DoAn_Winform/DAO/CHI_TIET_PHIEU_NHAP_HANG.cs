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
    
    public partial class CHI_TIET_PHIEU_NHAP_HANG
    {
        public int MAPNH { get; set; }
        public int MAHH { get; set; }
        public int SL { get; set; }
        public double GIA { get; set; }
    
        public virtual PHIEU_NHAP_HANG PHIEU_NHAP_HANG { get; set; }
        public virtual HANG_HOA HANG_HOA { get; set; }
    }
}