namespace DoAn_Winform
{
    partial class frmTraCuuDonDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuDonDatHang));
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDsDDH = new System.Windows.Forms.DataGridView();
            this.colMaDDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNVLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lvwChiTietDDH = new System.Windows.Forms.ListView();
            this.colTenHH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChonDDH = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(156, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(748, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách đơn đặt hàng đã duyệt";
            // 
            // dtgvDsDDH
            // 
            this.dtgvDsDDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDsDDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDsDDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDDH,
            this.colNgayLap,
            this.colTenNVLap});
            this.dtgvDsDDH.Location = new System.Drawing.Point(12, 174);
            this.dtgvDsDDH.Name = "dtgvDsDDH";
            this.dtgvDsDDH.ReadOnly = true;
            this.dtgvDsDDH.RowTemplate.Height = 24;
            this.dtgvDsDDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDsDDH.Size = new System.Drawing.Size(654, 467);
            this.dtgvDsDDH.TabIndex = 1;
            this.dtgvDsDDH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dtgvDsDDH_MouseClick);
            // 
            // colMaDDH
            // 
            this.colMaDDH.DataPropertyName = "Maddh";
            this.colMaDDH.HeaderText = "Mã đơn đặt hàng";
            this.colMaDDH.Name = "colMaDDH";
            this.colMaDDH.ReadOnly = true;
            // 
            // colNgayLap
            // 
            this.colNgayLap.DataPropertyName = "Ngaylap";
            this.colNgayLap.HeaderText = "Ngày lập";
            this.colNgayLap.Name = "colNgayLap";
            this.colNgayLap.ReadOnly = true;
            // 
            // colTenNVLap
            // 
            this.colTenNVLap.DataPropertyName = "Tennvlap";
            this.colTenNVLap.HeaderText = "Nhân viên lập";
            this.colTenNVLap.Name = "colTenNVLap";
            this.colTenNVLap.ReadOnly = true;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(153, 114);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(218, 30);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Image = global::DoAn_Winform.Properties.Resources.ngaySize48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(9, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 52);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenNgay.Location = new System.Drawing.Point(529, 114);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(227, 30);
            this.dtpDenNgay.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Image = global::DoAn_Winform.Properties.Resources.ngaySize48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(378, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 52);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvwChiTietDDH
            // 
            this.lvwChiTietDDH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenHH,
            this.colSoLuong});
            this.lvwChiTietDDH.Location = new System.Drawing.Point(673, 174);
            this.lvwChiTietDDH.Name = "lvwChiTietDDH";
            this.lvwChiTietDDH.Size = new System.Drawing.Size(477, 467);
            this.lvwChiTietDDH.TabIndex = 6;
            this.lvwChiTietDDH.UseCompatibleStateImageBehavior = false;
            this.lvwChiTietDDH.View = System.Windows.Forms.View.Details;
            // 
            // colTenHH
            // 
            this.colTenHH.Text = "Tên hàng hóa";
            this.colTenHH.Width = 172;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 200;
            // 
            // btnChonDDH
            // 
            this.btnChonDDH.Image = global::DoAn_Winform.Properties.Resources.LuaChonSize48;
            this.btnChonDDH.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonDDH.Location = new System.Drawing.Point(923, 97);
            this.btnChonDDH.Name = "btnChonDDH";
            this.btnChonDDH.Size = new System.Drawing.Size(227, 60);
            this.btnChonDDH.TabIndex = 5;
            this.btnChonDDH.Text = "Chọn đơn đặt hàng";
            this.btnChonDDH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonDDH.UseVisualStyleBackColor = true;
            this.btnChonDDH.Click += new System.EventHandler(this.btnChonDDH_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::DoAn_Winform.Properties.Resources.timkiem;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Location = new System.Drawing.Point(767, 97);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 60);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmTraCuuDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1162, 653);
            this.Controls.Add(this.lvwChiTietDDH);
            this.Controls.Add(this.btnChonDDH);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.dtpTuNgay);
            this.Controls.Add(this.dtgvDsDDH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1180, 700);
            this.Name = "frmTraCuuDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tra cứu đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmTraCuuDonDatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDsDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDsDDH;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnChonDDH;
        private System.Windows.Forms.ListView lvwChiTietDDH;
        private System.Windows.Forms.ColumnHeader colTenHH;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNVLap;
    }
}