﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class LoaiThucUongDAO
    {
        QUAN_LI_QUAN_CAFE_HBK_Entities1 db = new QUAN_LI_QUAN_CAFE_HBK_Entities1();

        public List<LoaiThucUongDTO> LoadDsLoaiTU()
        {
            return db.LOAI_THUC_UONG.Where(p => p.TRANGTHAIXOA == false).Select(p => new LoaiThucUongDTO
            { Maloaitu = p.MALOAITU, Tenloaitu = p.TENLOAITU }).ToList();
        }

        public LoaiThucUongDTO TimKiemLoaiTU(string tenLTU)
        {
            return db.LOAI_THUC_UONG.Where(p => p.TRANGTHAIXOA == false && p.TENLOAITU == tenLTU).Select(p => new LoaiThucUongDTO
            { Maloaitu = p.MALOAITU, Tenloaitu = p.TENLOAITU }).SingleOrDefault();
        }

        public bool ThemLoaiTU(LoaiThucUongDTO ltu)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = new LOAI_THUC_UONG
                {
                    TENLOAITU = ltu.Tenloaitu
                };
                db.LOAI_THUC_UONG.Add(ltuDB);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool SuaLoaiTU(LoaiThucUongDTO ltu)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = db.LOAI_THUC_UONG.SingleOrDefault(p => p.MALOAITU == ltu.Maloaitu && p.TRANGTHAIXOA == false);
                ltuDB.TENLOAITU = ltu.Tenloaitu;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool XoaLoaiTU(int maLoaiTU)
        {
            try
            {
                LOAI_THUC_UONG ltuDB = db.LOAI_THUC_UONG.SingleOrDefault(p => p.MALOAITU == maLoaiTU && p.TRANGTHAIXOA == false);
                ltuDB.TRANGTHAIXOA = true;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string TimLoaiThucUongTheoTenTU(string TenTU)
        {
            string TenLoaiTU;
            try
            {
                TenLoaiTU = db.LOAI_THUC_UONG.Where(u => u.TENLOAITU == TenTU).SingleOrDefault().TENLOAITU;
            }
            catch (Exception e)
            {
                TenLoaiTU = string.Empty;
            }
            return TenLoaiTU;
        }
    }
}
