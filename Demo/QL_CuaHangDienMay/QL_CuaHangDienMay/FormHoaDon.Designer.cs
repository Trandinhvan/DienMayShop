namespace QL_CuaHangDienMay
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.txt_NhaVienLap = new System.Windows.Forms.TextBox();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_loaiSP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txt_ThanhTien = new System.Windows.Forms.TextBox();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.number_sl = new System.Windows.Forms.NumericUpDown();
            this.cb_SP = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnReset = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_cthd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pd_HoaDon = new System.Drawing.Printing.PrintDocument();
            this.ppd_HoaDon = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(462, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.txt_MaKH);
            this.groupBox1.Controls.Add(this.txt_NhaVienLap);
            this.groupBox1.Controls.Add(this.txt_maHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(68, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(138, 160);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(277, 22);
            this.txt_MaKH.TabIndex = 8;
            // 
            // txt_NhaVienLap
            // 
            this.txt_NhaVienLap.Location = new System.Drawing.Point(138, 103);
            this.txt_NhaVienLap.Name = "txt_NhaVienLap";
            this.txt_NhaVienLap.Size = new System.Drawing.Size(277, 22);
            this.txt_NhaVienLap.TabIndex = 5;
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(138, 43);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(277, 22);
            this.txt_maHD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhân viên lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.cb_loaiSP);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.txt_ThanhTien);
            this.groupBox2.Controls.Add(this.txt_donGia);
            this.groupBox2.Controls.Add(this.number_sl);
            this.groupBox2.Controls.Add(this.cb_SP);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(519, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 288);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // cb_loaiSP
            // 
            this.cb_loaiSP.FormattingEnabled = true;
            this.cb_loaiSP.Location = new System.Drawing.Point(192, 26);
            this.cb_loaiSP.Name = "cb_loaiSP";
            this.cb_loaiSP.Size = new System.Drawing.Size(278, 24);
            this.cb_loaiSP.TabIndex = 12;
            this.cb_loaiSP.SelectedIndexChanged += new System.EventHandler(this.cb_loaiSP_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Loại Sản phẩm:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(193, 248);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // txt_ThanhTien
            // 
            this.txt_ThanhTien.Location = new System.Drawing.Point(192, 203);
            this.txt_ThanhTien.Name = "txt_ThanhTien";
            this.txt_ThanhTien.ReadOnly = true;
            this.txt_ThanhTien.Size = new System.Drawing.Size(277, 22);
            this.txt_ThanhTien.TabIndex = 9;
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(192, 114);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.ReadOnly = true;
            this.txt_donGia.Size = new System.Drawing.Size(277, 22);
            this.txt_donGia.TabIndex = 8;
            // 
            // number_sl
            // 
            this.number_sl.Location = new System.Drawing.Point(192, 160);
            this.number_sl.Name = "number_sl";
            this.number_sl.Size = new System.Drawing.Size(120, 22);
            this.number_sl.TabIndex = 7;
            this.number_sl.ValueChanged += new System.EventHandler(this.number_sl_ValueChanged);
            // 
            // cb_SP
            // 
            this.cb_SP.FormattingEnabled = true;
            this.cb_SP.Location = new System.Drawing.Point(192, 67);
            this.cb_SP.Name = "cb_SP";
            this.cb_SP.Size = new System.Drawing.Size(278, 24);
            this.cb_SP.TabIndex = 6;
            this.cb_SP.SelectedIndexChanged += new System.EventHandler(this.cb_SP_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Thời gian bảo hành:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thành tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sản phẩm:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(909, 362);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(130, 42);
            this.simpleButton1.TabIndex = 33;
            this.simpleButton1.Text = "Thoát";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.ImageOptions.Image")));
            this.btnThemMoi.Location = new System.Drawing.Point(269, 362);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(130, 42);
            this.btnThemMoi.TabIndex = 31;
            this.btnThemMoi.Text = "Thêm";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnReset
            // 
            this.btnReset.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Appearance.Options.UseForeColor = true;
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.Location = new System.Drawing.Point(519, 362);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 42);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgv_cthd
            // 
            this.dgv_cthd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cthd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_cthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_cthd.Location = new System.Drawing.Point(12, 419);
            this.dgv_cthd.Name = "dgv_cthd";
            this.dgv_cthd.RowTemplate.Height = 24;
            this.dgv_cthd.Size = new System.Drawing.Size(1073, 200);
            this.dgv_cthd.TabIndex = 35;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAHD";
            this.Column1.HeaderText = "Mã Hóa Đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MASANPHAM";
            this.Column2.HeaderText = "Mã Sản Phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số Lượng";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DONGIA";
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "THANHTIEN";
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TGBH";
            this.Column6.HeaderText = "Thời Gian Bảo Hành (tháng)";
            this.Column6.Name = "Column6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(658, 656);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tổng Tiền";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(737, 653);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(277, 22);
            this.txt_tongtien.TabIndex = 13;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(711, 362);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.Size = new System.Drawing.Size(130, 42);
            this.simpleButton2.TabIndex = 37;
            this.simpleButton2.Text = "Thanh Toán";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pd_HoaDon
            // 
            this.pd_HoaDon.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pd_HoaDon_PrintPage);
            // 
            // ppd_HoaDon
            // 
            this.ppd_HoaDon.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd_HoaDon.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd_HoaDon.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd_HoaDon.Enabled = true;
            this.ppd_HoaDon.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd_HoaDon.Icon")));
            this.ppd_HoaDon.Name = "ppd_HoaDon";
            this.ppd_HoaDon.Visible = false;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1147, 740);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_cthd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NhaVienLap;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txt_ThanhTien;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.NumericUpDown number_sl;
        private System.Windows.Forms.ComboBox cb_SP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private DevExpress.XtraEditors.SimpleButton btnReset;
        private System.Windows.Forms.DataGridView dgv_cthd;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_loaiSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tongtien;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Drawing.Printing.PrintDocument pd_HoaDon;
        private System.Windows.Forms.PrintPreviewDialog ppd_HoaDon;
    }
}