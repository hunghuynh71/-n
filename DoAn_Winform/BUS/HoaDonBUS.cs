﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdTam = new HoaDonDAO();
        public HoaDonDTO LoadHDChuaThanhToanTheoMaBan(int maBan)
        {
            return hdTam.LoadHDChuaThanhToanTheoMaBan(maBan);
        }

        public List<HoaDonDTO> LoadDsHDTrongNgay()
        {
            return hdTam.LoadDsHDTrongNgay();
        }

        public bool ThemThucUongTheoBan(BanDTO ban , int Manv , string TenTU, string LoaiTU,int SoLg)
        {
            return hdTam.ThemThucUongTheoBan(ban,Manv,TenTU,LoaiTU,SoLg);
        }
        public bool ThanhToan(BanDTO ban)
        {
            return hdTam.ThanhToan(ban);
        }
        public bool ChuyenBan(BanDTO ban, string TenBan,int MavnLap)
        {
            return hdTam.ChuyenBan(ban, TenBan,MavnLap);
        }
    }
}
