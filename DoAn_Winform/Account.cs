using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAn_Winform
{
    public partial class frmAccount : Form
    {
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;          
            InitializeComponent();
            txtTenTaiKhoan.Text = tk.Tendangnhap;
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhau.Text = "";
        }

        private void btnThayDoiAccount_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS tkbus = new TaiKhoanBUS();
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
                MessageBox.Show(Instance.TBNhapThieuTT, Instance.CanhBao);
            else if(txtMatKhauCu.Text == txtMatKhauMoi.Text)
                MessageBox.Show(Instance.TBMkMoiPhaiGiongMkCu, Instance.CanhBao);
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
                MessageBox.Show(Instance.TBNhapLaiMkMoiKhongDung, Instance.CanhBao);
            else
            {
                if(tkbus.SuaTK(TaiKhoanGlobal,txtMatKhauCu.Text,txtMatKhauMoi.Text))
                    MessageBox.Show(Instance.TBCapNhatMkThanhCong, Instance.ThongBao);
                else
                    MessageBox.Show(Instance.TBNhapSaiMkCu, Instance.ThatBai);
            }
            txtMatKhauCu.Text = string.Empty;
            txtMatKhauMoi.Text = string.Empty;
            txtNhapLaiMatKhau.Text = string.Empty;
        }


        
        private void btnThoatAccount_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != "" || txtMatKhauMoi.Text != "" || txtNhapLaiMatKhau.Text != "")
            {
                DialogResult res = MessageBox.Show(Instance.XacNhanThoat, Instance.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                    this.Close();
            }
            else
                this.Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }

    }
}
