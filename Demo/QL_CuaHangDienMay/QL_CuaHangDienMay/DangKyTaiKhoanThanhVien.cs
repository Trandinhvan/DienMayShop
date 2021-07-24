using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace QL_CuaHangDienMay
{
    public partial class DangKyTaiKhoanThanhVien : Form
    {
        XuLy xl = new XuLy();   
        public DangKyTaiKhoanThanhVien()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtsothe.Focus();
            txtdiachi.Clear();
            txtmakh.Clear();
            txtsothe.Clear();
            txttenkhachhang.Clear();
        }

        private void txtsothe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số vào !");
            }
        }

        private void txtmakh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số vào !");
            }
        }

        private void DangKyTaiKhoanThanhVien_Load(object sender, EventArgs e)
        {
            txtngaycap.Text = DateTime.Today.ToShortDateString();
            gCThanhVien.DataSource = xl.getTV();
            cbomanv.DataSource = xl.getNV();
            cbomanv.DisplayMember = "MANV";
            txtmakh.Enabled = false;

        }

        
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtsothe.Text == string.Empty || cbomanv.Text == string.Empty || txtngaycap.Text == string.Empty || txtmakh.Text == string.Empty || txttenkhachhang.Text == string.Empty || txtdiachi.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    if (xl.InsertKH(txtmakh.Text, txttenkhachhang.Text, txtdiachi.Text, txtsothe.Text) == true)
                    {
                        gCThanhVien.DataSource = xl.InsertTktv(txtsothe.Text, cbomanv.Text, txtmakh.Text, DateTime.Parse(txtngaycap.Text));
                        gCThanhVien.DataSource = xl.getTV();
                        MessageBox.Show("Tạo tài khoản thành công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void gCThanhVien_Click(object sender, EventArgs e)
        {

        }

        private void txtsothe_Leave(object sender, EventArgs e)
        {
            if (txtsothe.Text == string.Empty)
            {
                errorProvider1.SetError(txtsothe, "Không được để trống!");
            }
            else
            {
                errorProvider1.Clear();
                txtmakh.Text = txtsothe.Text;
            }
        }

        

        private void txttenkhachhang_Leave(object sender, EventArgs e)
        {
            if (txttenkhachhang.Text == string.Empty)
            {
                errorProvider1.SetError(txttenkhachhang, "không được để trống!");
            }
            else
                errorProvider1.Clear();
        }

        private void txtdiachi_Leave(object sender, EventArgs e)
        {
            if (txtdiachi.Text == string.Empty)
            {
                errorProvider1.SetError(txtdiachi, "không được để trống!");
            }
            else
                errorProvider1.Clear();
        }
    }
}
