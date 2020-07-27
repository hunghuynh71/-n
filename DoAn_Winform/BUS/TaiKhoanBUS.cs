﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoanDAO tkTam = new TaiKhoanDAO();

        public bool SuaTK(TaiKhoanDTO tkSUa,string MatkhauCu,string MatKhauMoi)
        {
            return tkTam.SuaTK(tkSUa, MatkhauCu, MatKhauMoi);
        }
        public List<TaiKhoanDTO> LoadDsTK()
        {
            return tkTam.LoadDsTK();
        }

        public List<TaiKhoanDTO> TimKiemTK(string tenDN)
        {
            return tkTam.TimKiemTK(tenDN);
        }

        public bool ThemTK(TaiKhoanDTO tk)
        {
            return tkTam.ThemTK(tk);
        }

        public bool XoaTK(string tenDN)
        {
            return tkTam.XoaTK(tenDN);
        }
        public bool KiemTraDangNhap(out TaiKhoanDTO tk , string TenDN,string MatKh)
        {
            return tkTam.KiemTraDangNhap(out tk, TenDN, MatKh);
        }
    
    }
}
