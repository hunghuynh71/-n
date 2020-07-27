namespace DoAn_Winform
{
    partial class frmChonBaoCao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonBaoCao));
            this.radBCDoanhThuTrongKhoan = new System.Windows.Forms.RadioButton();
            this.radBCDoanhThuTrongNgay = new System.Windows.Forms.RadioButton();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radBCDoanhThuTungSPTrongThang = new System.Windows.Forms.RadioButton();
            this.radBCChiTieuTrongNgay = new System.Windows.Forms.RadioButton();
            this.radBCChiTieuTrongKhoan = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radBCDoanhThuTrongKhoan
            // 
            this.radBCDoanhThuTrongKhoan.AutoSize = true;
            this.radBCDoanhThuTrongKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radBCDoanhThuTrongKhoan.Location = new System.Drawing.Point(918, 170);
            this.radBCDoanhThuTrongKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTrongKhoan.Name = "radBCDoanhThuTrongKhoan";
            this.radBCDoanhThuTrongKhoan.Size = new System.Drawing.Size(231, 29);
            this.radBCDoanhThuTrongKhoan.TabIndex = 0;
            this.radBCDoanhThuTrongKhoan.TabStop = true;
            this.radBCDoanhThuTrongKhoan.Text = "Doanh thu trong khoản";
            this.radBCDoanhThuTrongKhoan.UseVisualStyleBackColor = false;
            this.radBCDoanhThuTrongKhoan.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTrongKhoan_CheckedChanged);
            // 
            // radBCDoanhThuTrongNgay
            // 
            this.radBCDoanhThuTrongNgay.AutoSize = true;
            this.radBCDoanhThuTrongNgay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radBCDoanhThuTrongNgay.Location = new System.Drawing.Point(228, 170);
            this.radBCDoanhThuTrongNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTrongNgay.Name = "radBCDoanhThuTrongNgay";
            this.radBCDoanhThuTrongNgay.Size = new System.Drawing.Size(220, 29);
            this.radBCDoanhThuTrongNgay.TabIndex = 0;
            this.radBCDoanhThuTrongNgay.TabStop = true;
            this.radBCDoanhThuTrongNgay.Text = "Doanh thu trong ngày";
            this.radBCDoanhThuTrongNgay.UseVisualStyleBackColor = false;
            this.radBCDoanhThuTrongNgay.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTrongNgay_CheckedChanged);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(851, 343);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(298, 30);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(851, 268);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(298, 30);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(367, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 69);
            this.label3.TabIndex = 3;
            this.label3.Text = "Báo cáo thống kê";
            // 
            // radBCDoanhThuTungSPTrongThang
            // 
            this.radBCDoanhThuTungSPTrongThang.AutoSize = true;
            this.radBCDoanhThuTungSPTrongThang.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radBCDoanhThuTungSPTrongThang.Location = new System.Drawing.Point(228, 346);
            this.radBCDoanhThuTungSPTrongThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCDoanhThuTungSPTrongThang.Name = "radBCDoanhThuTungSPTrongThang";
            this.radBCDoanhThuTungSPTrongThang.Size = new System.Drawing.Size(360, 29);
            this.radBCDoanhThuTungSPTrongThang.TabIndex = 0;
            this.radBCDoanhThuTungSPTrongThang.TabStop = true;
            this.radBCDoanhThuTungSPTrongThang.Text = "Doanh thu từng sản phẩm trong tháng\r\n";
            this.radBCDoanhThuTungSPTrongThang.UseVisualStyleBackColor = false;
            this.radBCDoanhThuTungSPTrongThang.CheckedChanged += new System.EventHandler(this.radBCDoanhThuTungSPTrongThang_CheckedChanged);
            // 
            // radBCChiTieuTrongNgay
            // 
            this.radBCChiTieuTrongNgay.AutoSize = true;
            this.radBCChiTieuTrongNgay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radBCChiTieuTrongNgay.Location = new System.Drawing.Point(228, 257);
            this.radBCChiTieuTrongNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCChiTieuTrongNgay.Name = "radBCChiTieuTrongNgay";
            this.radBCChiTieuTrongNgay.Size = new System.Drawing.Size(196, 29);
            this.radBCChiTieuTrongNgay.TabIndex = 0;
            this.radBCChiTieuTrongNgay.TabStop = true;
            this.radBCChiTieuTrongNgay.Text = "Chi tiêu trong ngày";
            this.radBCChiTieuTrongNgay.UseVisualStyleBackColor = false;
            this.radBCChiTieuTrongNgay.CheckedChanged += new System.EventHandler(this.radBCChiTieuTrongNgay_CheckedChanged);
            // 
            // radBCChiTieuTrongKhoan
            // 
            this.radBCChiTieuTrongKhoan.AutoSize = true;
            this.radBCChiTieuTrongKhoan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.radBCChiTieuTrongKhoan.Location = new System.Drawing.Point(685, 170);
            this.radBCChiTieuTrongKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBCChiTieuTrongKhoan.Name = "radBCChiTieuTrongKhoan";
            this.radBCChiTieuTrongKhoan.Size = new System.Drawing.Size(207, 29);
            this.radBCChiTieuTrongKhoan.TabIndex = 0;
            this.radBCChiTieuTrongKhoan.TabStop = true;
            this.radBCChiTieuTrongKhoan.Text = "Chi tiêu trong khoản";
            this.radBCChiTieuTrongKhoan.UseVisualStyleBackColor = false;
            this.radBCChiTieuTrongKhoan.CheckedChanged += new System.EventHandler(this.radBCChiTieuTrongKhoan_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DoAn_Winform.Properties.Resources.BieuDoDuongThongKe;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 160);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Image = global::DoAn_Winform.Properties.Resources.ngaySize48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(682, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến ngày:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Image = global::DoAn_Winform.Properties.Resources.ngaySize48;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(682, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXemBaoCao.Image = global::DoAn_Winform.Properties.Resources.TraCuuSize48;
            this.btnXemBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXemBaoCao.Location = new System.Drawing.Point(511, 510);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(215, 92);
            this.btnXemBaoCao.TabIndex = 1;
            this.btnXemBaoCao.Text = "Xem báo cáo";
            this.btnXemBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // frmChonBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::DoAn_Winform.Properties.Resources.GiaoDIenbieuDoThogKE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.radBCChiTieuTrongNgay);
            this.Controls.Add(this.radBCDoanhThuTrongNgay);
            this.Controls.Add(this.radBCDoanhThuTungSPTrongThang);
            this.Controls.Add(this.radBCChiTieuTrongKhoan);
            this.Controls.Add(this.radBCDoanhThuTrongKhoan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "frmChonBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn báo cáo";
            this.Load += new System.EventHandler(this.frmChonBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radBCDoanhThuTrongKhoan;
        private System.Windows.Forms.RadioButton radBCDoanhThuTrongNgay;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radBCDoanhThuTungSPTrongThang;
        private System.Windows.Forms.RadioButton radBCChiTieuTrongNgay;
        private System.Windows.Forms.RadioButton radBCChiTieuTrongKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}