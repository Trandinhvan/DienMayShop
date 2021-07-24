using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;
using BLL;

namespace QL_CuaHangDienMay
{
    public partial class FormDangNhap : Form
    {
        public static string setValueForTextDangNhap = "";
        public static string setValueForTextMatKhau = "";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        QL_NguoiDung CauHinh = new QL_NguoiDung();
        public enum LoginResult
        {
            /// <summary>
            /// Wrong username or password
            /// </summary>
            Invalid,
            /// <summary>
            /// User had been disabled
            /// </summary>
            Disabled,
            /// <summary>
            /// Loging success
            /// </summary>
            Success
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            DangKy frmDangKy = new DangKy();
            frmDangKy.ShowDialog();
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Form1 frmMain = new Form1();
            //frmMain.ShowDialog();
            //this.Hide();
            setValueForTextDangNhap = txTenDangNhap.Text;
            setValueForTextMatKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(txTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống" + label1.Text.ToLower());
                this.txTenDangNhap.Focus();
                return;
            }
            if (string.IsNullOrEmpty(this.txtMatKhau.Text))
            {
                MessageBox.Show("Không được bỏ trống" + label2.Text.ToLower());
                this.txtMatKhau.Focus();
                return;
            }
            int kq = CauHinh.Check_Config(); //hàm Check_Config() thuộc Class QL_NguoiDung
            if (kq == 0)
            {
                ProcessLogin();// Cấu hình phù hợp xử lý đăng nhập
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
                //ProcessConfig();
            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
                //ProcessConfig();
            }
        }

        public void ProcessLogin()
        {
            int result;
            result = CauHinh.Check_User(txTenDangNhap.Text, txtMatKhau.Text);
            if (result == 1)
            {
                MessageBox.Show("Sai " + label1.Text + " Hoặc " +
                label2.Text);
                return;
            }
            // Account had been disabled
            else if (result == 0)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            else
            {
                Program.TenDN = txTenDangNhap.Text;
                Form1 formMain = new Form1();
                formMain.Show();

                this.Hide();

            }
        }

        private void txTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            //Control ctr = (Control)sender;
            //foreach (char ch in txTenDangNhap.Text)
            //{
            //    if (char.IsDigit(ch) == false)
            //    {
            //        this.dxErrorProvider1.SetError(ctr, "Bạn phải nhập số vào");
            //        //txtGiaBan.Clear();
            //    }
            //    else
            //    {
            //        this.dxErrorProvider1.ClearErrors();
            //    }
            //}

        }

        private void txTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txTenDangNhap.Text == String.Empty)
            {
                this.dxErrorProvider1.SetError(txTenDangNhap, "Tên đăng nhập không được rỗng");
            }
            else
            {
                this.dxErrorProvider1.ClearErrors();
            }
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
     
        }
    }
}
