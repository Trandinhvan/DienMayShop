namespace QL_CuaHangDienMay
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.gCKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gCTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gCKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            // 
            // gCKhachHang
            // 
            this.gCKhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gCKhachHang.Location = new System.Drawing.Point(166, 69);
            this.gCKhachHang.MainView = this.gridView1;
            this.gCKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.gCKhachHang.Name = "gCKhachHang";
            this.gCKhachHang.Size = new System.Drawing.Size(904, 299);
            this.gCKhachHang.TabIndex = 3;
            this.gCKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gCKhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khách hàng";
            this.gridColumn1.FieldName = "MAKH";
            this.gridColumn1.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.Image")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên khách hàng";
            this.gridColumn2.FieldName = "TENKH";
            this.gridColumn2.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Địa chỉ";
            this.gridColumn3.FieldName = "DCHI";
            this.gridColumn3.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.Image")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Số điện thoại";
            this.gridColumn4.FieldName = "DT";
            this.gridColumn4.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(449, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(399, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DANH SÁCH TÀI KHOẢN THÀNH VIÊN";
            // 
            // gCTaiKhoan
            // 
            this.gCTaiKhoan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gCTaiKhoan.Location = new System.Drawing.Point(166, 422);
            this.gCTaiKhoan.MainView = this.gridView2;
            this.gCTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.gCTaiKhoan.Name = "gCTaiKhoan";
            this.gCTaiKhoan.Size = new System.Drawing.Size(904, 334);
            this.gCTaiKhoan.TabIndex = 5;
            this.gCTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.gridView2.GridControl = this.gCTaiKhoan;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Mã tài khoản";
            this.gridColumn5.FieldName = "SOTHE";
            this.gridColumn5.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn5.Image")));
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Mã nhân viên cấp";
            this.gridColumn6.FieldName = "MANV";
            this.gridColumn6.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.Image")));
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã khách hàng";
            this.gridColumn7.FieldName = "MAKH";
            this.gridColumn7.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn7.Image")));
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ngày cấp ";
            this.gridColumn8.FieldName = "NGAYCAP";
            this.gridColumn8.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn8.Image")));
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1137, 766);
            this.Controls.Add(this.gCTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gCKhachHang);
            this.Controls.Add(this.label1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.gCKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gCTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gCKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gCTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}