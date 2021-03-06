﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace DoAn_Winform
{
    public partial class frmBanHang : Form
    {
        BanDTO BanGlobal = new BanDTO();
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        HoaDonBUS hdbus = new HoaDonBUS();
        BanBUS banBUS = new BanBUS();
        public frmBanHang()
        {
            InitializeComponent();      
        }
        public frmBanHang(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;
            InitializeComponent();
        }
       
        #region Method
        private void frmBanHang_Load(object sender, EventArgs e)
        {           
            LoadDsBan(BanGlobal);
            LoadcboChuyenBan();
            LoadcboLoaiThucUong();
            LoadcboThucUong();
        }   
       public void LoadDsBan(BanDTO banglobal)
        {
            flpBan.Controls.Clear();
            List<BanDTO> dsBan = banBUS.LoadDsBan();

            foreach(BanDTO item in dsBan)
            {
                Button button = new Button() { Width = Instance.ChieuDaiBan, Height = Instance.ChieuRongBan};

                button.Click += button_Click;           
                button.Tag = item;

                button.Image = Image.FromFile(Instance.HinhAnhBan);
                button.ImageAlign=ContentAlignment.MiddleLeft;
                button.TextAlign = ContentAlignment.MiddleRight;

                if(item.Trangthai == 1)
                {
                    button.Text = item.Tenban + Instance.BanTrong;
                    if (banglobal.Soban != item.Soban)
                        button.BackColor = Color.LightGreen;
                    else
                        button.BackColor = Color.SkyBlue;
                }
                else if (item.Trangthai == 2)
                {
                    button.Text = item.Tenban + Instance.BanKhongTrong;
                    if (banglobal.Soban != item.Soban)
                         button.BackColor = Color.LightPink;
                    else
                        button.BackColor = Color.SkyBlue;
                }

                flpBan.Controls.Add(button);
            }
        }
        void LoadcboThucUong()
        {
            ThucUongBUS tubus = new ThucUongBUS();
            List< ThucUongDTO> TuDTO = new List<ThucUongDTO>();
            TuDTO = tubus.LoadDsTU();
            foreach(ThucUongDTO tu in TuDTO)
            {
                cboThucUong.Items.Add(tu.Tentu);
            }    
        }
        void LoadcboLoaiThucUong()
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            List<LoaiThucUongDTO> LoaiTuDTO = new List<LoaiThucUongDTO>();
            LoaiTuDTO = ltubus.LoadDsLoaiTU();
            foreach (LoaiThucUongDTO tu in LoaiTuDTO)
            {
                cboLoaiThucUong.Items.Add(tu.Tenloaitu);
            }
        }
        void LoadcboChuyenBan()
        {
            
            List<BanDTO> Listbbus = new List<BanDTO>();
            Listbbus = banBUS.LoadDsBan();
            foreach (BanDTO bann in Listbbus)
            {
                cboChuyenBan.Items.Add(bann.Tenban);
            }
        }   
        public void LoadThongTinHD(int maBan)
        {
            if (maBan != null)
            {
                HoaDonBUS hdBUS = new HoaDonBUS();
                ChiTietHoaDonBUS cthdBUS = new ChiTietHoaDonBUS();
                lvwHoaDon.Items.Clear();
                HoaDonDTO hdTam = hdBUS.LoadHDChuaThanhToanTheoMaBan(maBan);
                if (hdTam != null)
                {
                    List<ChiTietHoaDonDTO> dsCT = cthdBUS.LoadDsCTHDTheoMaHD(hdTam.Mahd);
                    double tongTien = 0;

                    foreach (ChiTietHoaDonDTO item in dsCT)
                    {
                        ListViewItem lvi = new ListViewItem(item.Tentu);
                        lvi.SubItems.Add(item.Soluong.ToString());
                        lvi.SubItems.Add(item.Giaban.ToString());
                        lvi.SubItems.Add(item.Thanhtien.ToString());

                        lvwHoaDon.Items.Add(lvi);

                        tongTien += item.Thanhtien;
                    }
                    //tongTien = tongTien - (tongTien * Convert.ToDouble(nmrPhanTramGiamGia.Value) / 100);
                    txtTongTien.Text = tongTien.ToString();
                    txtTongTien.ReadOnly = true;
                }
            }                     
        }

        #endregion


        #region Event

        private void button_Click(object sender, EventArgs e)
        {
            BanGlobal = ((sender as Button).Tag as BanDTO);
            int maBan = ((sender as Button).Tag as BanDTO).Soban;
            (sender as Button).BackColor= Color.SkyBlue;
            LoadThongTinHD(maBan);
            btnThemThucUong.Enabled = true;
            LoadDsBan(BanGlobal);
            if(lvwHoaDon.Items.Count > 0)
            {
                btnThanhToan.Enabled = true;
                btnChuyenBan.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                btnChuyenBan.Enabled = false;
            }

        }
        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            if (cboThucUong.Text != "" && cboLoaiThucUong.Text != "")
            {
                if (hdbus.ThemThucUongTheoBan(BanGlobal, TaiKhoanGlobal.Manv, cboThucUong.Text, cboLoaiThucUong.Text, Convert.ToInt32(nmrSoLuong.Value)))
                { 
                    MessageBox.Show(Instance.TBThemThanhCong, Instance.ThanhCong);
                    btnThanhToan.Enabled = true;
                    btnChuyenBan.Enabled = true;
                    BanGlobal.Trangthai = 2;
                    LoadThongTinHD(BanGlobal.Soban);              
                    LoadDsBan(BanGlobal);
                }
                else
                    MessageBox.Show(Instance.TBThemThatBai, Instance.Loi);
            }
            else
                MessageBox.Show(Instance.TBNhapThieuTT, Instance.CanhBao);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult mes = MessageBox.Show(Instance.HoiXacNhanThanhToan, Instance.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(mes==DialogResult.Yes)
            {
                if (hdbus.ThanhToan(BanGlobal,Convert.ToDouble(txtTongTien.Text)))
                {
                    MessageBox.Show(Instance.TBThanhToanThanhCong, Instance.ThanhCong);
                    LoadDsBan(BanGlobal);
                    lvwHoaDon.Items.Clear();
                }
            }   
            else
            {
                MessageBox.Show(Instance.TBDaHuyThanhToan, Instance.ThongBao);
            }    

        }
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (!banBUS.KiemTraBanCoNguoiChua(cboChuyenBan.Text) && cboChuyenBan.Text !="" && cboChuyenBan.Text != BanGlobal.Tenban)
            {
                DialogResult res = MessageBox.Show(Instance.XacNhanChuyenBan, Instance.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    res = MessageBox.Show(Instance.HoiXacNhanThemMonVaoBanQuenBiet, Instance.ThongBao, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        if (hdbus.ChuyenBan(BanGlobal, cboChuyenBan.Text,TaiKhoanGlobal.Manv))
                        { 
                            MessageBox.Show(Instance.ThanhCong, Instance.ThongBao);
                            BanGlobal.Trangthai = 1;
                            LoadDsBan(BanGlobal);
                        }
                        else
                            MessageBox.Show(Instance.ThatBai, Instance.ThongBao);
                    }
                }
            }
            else if (cboChuyenBan.Text != "" && cboChuyenBan.Text != BanGlobal.Tenban)
            {
                if (hdbus.ChuyenBan(BanGlobal, cboChuyenBan.Text,TaiKhoanGlobal.Manv))
                        { 
                            MessageBox.Show(Instance.ThanhCong, Instance.ThongBao);
                            BanGlobal.Trangthai = 1;
                            LoadDsBan(BanGlobal);
                        }
                        else
                            MessageBox.Show(Instance.ThatBai, Instance.ThongBao);
            }
            else
                MessageBox.Show(Instance.TBNhapThieuTT, Instance.CanhBao);
            cboChuyenBan.Text = string.Empty;
        }
     
        private void cboThucUong_TextChanged(object sender, EventArgs e)
        {
            LoaiThucUongBUS ltubus = new LoaiThucUongBUS();
            string LoaiTU = ltubus.TimLoaiTUTheoTenloai(cboThucUong.Text);
            if (LoaiTU != "")
            {
                cboLoaiThucUong.Text = LoaiTU;
            }
        }
        private void cboLoaiThucUong_TextChanged(object sender, EventArgs e)
        {
            ThucUongBUS tubus = new ThucUongBUS();
            List<ThucUongDTO> ListTUDTO = tubus.TimDrinkTheoTenLoaiDrink(cboLoaiThucUong.Text);
            if (ListTUDTO.Count() > 0)
            {
                cboThucUong.Items.Clear();
                foreach (ThucUongDTO tu in ListTUDTO)
                {
                    cboThucUong.Items.Add(tu.Tentu);
                }
            }
        }
        private void cboLoaiThucUong_Click(object sender, EventArgs e)
        {
            cboThucUong.Text = "";
        }

        private void btnGiamGia_Click(object sender, EventArgs e)
        {
            //double tongTien = Convert.ToDouble(txtTongTien.Text);
            double tongTien=0;
            foreach(ListViewItem lvi in lvwHoaDon.Items)
            {
                tongTien += Convert.ToDouble(lvi.SubItems[3].Text);
            }
            //tongTien = Convert.ToDouble(txtTongTien.Text);
            tongTien = tongTien - (tongTien * Convert.ToDouble(nmrPhanTramGiamGia.Value) / 100);
            txtTongTien.Text = tongTien.ToString();
        }

        #endregion
    }
}
