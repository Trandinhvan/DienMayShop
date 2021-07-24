using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BLL;
using System.Text.RegularExpressions;


namespace QL_CuaHangDienMay
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XuLy xl = new XuLy();
        public Form1()
        {
            InitializeComponent();
        }
        APINhanDien nhandien = new APINhanDien();
        public void loadGUI()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel theme = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            theme.LookAndFeel.SkinName = "iMaginary";

            FormDangNhap dn = new FormDangNhap();

            if (xl.kiemTraQuyenDN(FormDangNhap.setValueForTextDangNhap, FormDangNhap.setValueForTextMatKhau) != 1)
            {
                barButtonItem4.Enabled = false;
                barButtonItem5.Enabled = false;
                barButtonItem6.Enabled = false;
                btnDangKy.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadGUI();
            
        }

        private Form isActive(Type ftype) //check if the form is show or not.
        {
            foreach(Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                    return f;
            }
            return null;
        }
       
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(DangKy)); //check form đăng nhập có show hay không.
            if(form==null) // nếu formdangnhap ko show
            {
                DangKy f = new DangKy(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.ShowDialog();
            this.Close(); 
        }

        /*public void MoForm(Form a)
        {
            if(a==null)
            {
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                a.Activate();
            }
        }*/

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormDoiMatKhau)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormDoiMatKhau f = new FormDoiMatKhau(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void btnLoaiSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormLoaiSanPham)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormLoaiSanPham f = new FormLoaiSanPham(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }

        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormSanPham)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormSanPham f = new FormSanPham(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormPhanQuyen)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormPhanQuyen f = new FormPhanQuyen(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormNhanVien)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormNhanVien f = new FormNhanVien(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItemCamerar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            Form form = isActive(typeof(Form_PhatHienKhachHang)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                Form_PhatHienKhachHang f = new Form_PhatHienKhachHang(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;
                
                    f.Show();  
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = isActive(typeof(FormHoaDon)); //check form đăng nhập có show hay không.
            if (form == null) // nếu formdangnhap ko show
            {
                FormHoaDon f = new FormHoaDon(); //tạo mới form đăng nhập và show nó.
                f.MdiParent = this;

                f.Show();
            }
            else
            {
                form.Activate(); // nếu form đăng nhập đã show trc đó, focus lại.
            }
        }

        
    }
}
