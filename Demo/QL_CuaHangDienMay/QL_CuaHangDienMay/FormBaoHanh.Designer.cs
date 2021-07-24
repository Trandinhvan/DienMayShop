namespace QL_CuaHangDienMay
{
    partial class FormBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoHanh));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gCPBH = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gCKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCPBH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gCKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.gCPBH);
            this.groupBox1.Location = new System.Drawing.Point(83, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu bảo hành";
            // 
            // gCPBH
            // 
            this.gCPBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCPBH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gCPBH.Location = new System.Drawing.Point(3, 18);
            this.gCPBH.MainView = this.gridView4;
            this.gCPBH.Margin = new System.Windows.Forms.Padding(4);
            this.gCPBH.Name = "gCPBH";
            this.gCPBH.Size = new System.Drawing.Size(935, 267);
            this.gCPBH.TabIndex = 1;
            this.gCPBH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            this.gCPBH.Click += new System.EventHandler(this.gCPBH_Click);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn18,
            this.gridColumn19,
            this.gridColumn20,
            this.gridColumn21,
            this.gridColumn22});
            this.gridView4.GridControl = this.gCPBH;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsFind.AlwaysVisible = true;
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "Mã bảo hành";
            this.gridColumn18.FieldName = "MAPBH";
            this.gridColumn18.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn18.Image")));
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.OptionsColumn.AllowEdit = false;
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "Mã nhân viên";
            this.gridColumn19.FieldName = "MANV";
            this.gridColumn19.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn19.Image")));
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "Mã khách hàng";
            this.gridColumn20.FieldName = "MAKH";
            this.gridColumn20.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn20.Image")));
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 3;
            // 
            // gridColumn21
            // 
            this.gridColumn21.Caption = "Ngày lập";
            this.gridColumn21.FieldName = "NGAYLAP";
            this.gridColumn21.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn21.Image")));
            this.gridColumn21.Name = "gridColumn21";
            this.gridColumn21.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn22
            // 
            this.gridColumn22.Caption = "Tổng Tiền";
            this.gridColumn22.FieldName = "TONGTIEN";
            this.gridColumn22.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn22.Image")));
            this.gridColumn22.Name = "gridColumn22";
            this.gridColumn22.OptionsColumn.AllowEdit = false;
            this.gridColumn22.Visible = true;
            this.gridColumn22.VisibleIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.gCKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(86, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // gCKhachHang
            // 
            this.gCKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gCKhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            gridLevelNode1.RelationName = "Level1";
            this.gCKhachHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gCKhachHang.Location = new System.Drawing.Point(3, 18);
            this.gCKhachHang.MainView = this.gridView1;
            this.gCKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.gCKhachHang.Name = "gCKhachHang";
            this.gCKhachHang.Size = new System.Drawing.Size(929, 262);
            this.gCKhachHang.TabIndex = 4;
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
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(652, 31);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(100, 28);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Exit";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // FormBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1068, 669);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBaoHanh";
            this.Text = "FormBaoHanh";
            this.Load += new System.EventHandler(this.FormBaoHanh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCPBH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gCKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gCPBH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn21;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn22;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gCKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
    }
}