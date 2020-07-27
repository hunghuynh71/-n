using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Winform
{
    public partial class frmLogin : Form
    {    
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
          
                            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text != null && txtTaiKhoan.Text != null)
            {
                TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
                if (tkbus.KiemTraDangNhap(out TaiKhoanGlobal, txtTaiKhoan.Text, txtMatKhau.Text))
                {

                    frmHome frmH = new frmHome(TaiKhoanGlobal);
                    //this.Close();
                    frmH.ShowDialog();                 
                }
                else
                {
                    MessageBox.Show(Instance.TBTTDNKhongDung, Instance.ThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Text = string.Empty;
                    txtTaiKhoan.Text = string.Empty;
                }
            }
            else
                MessageBox.Show(Instance.TBNhapThieuTT, Instance.CanhBao, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show(Instance.XacNhanThoat, Instance.XacNhan, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
                this.Close();
        }

    }
}
