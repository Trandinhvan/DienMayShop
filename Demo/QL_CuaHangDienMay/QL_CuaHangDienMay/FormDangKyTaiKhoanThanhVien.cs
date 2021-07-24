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
using DevExpress.XtraEditors;
namespace QL_CuaHangDienMay
{
    public partial class FormDangKyTaiKhoanThanhVien : Form
    {
        XuLy xl = new XuLy();   
        public FormDangKyTaiKhoanThanhVien()
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
                    try
                    {
                        xl.InsertKH(txtmakh.Text, txttenkhachhang.Text, txtdiachi.Text, txtsothe.Text);
                        gCThanhVien.DataSource = xl.InsertTktv(txtsothe.Text, cbomanv.Text, txtmakh.Text, DateTime.Parse(txtngaycap.Text));


                    }
                    catch (Exception ex)
                    {
                        gCThanhVien.DataSource = xl.InsertTktv(txtsothe.Text, cbomanv.Text, txtmakh.Text, DateTime.Parse(txtngaycap.Text));

                    }
                    gCThanhVien.DataSource = xl.getTV();

                    MessageBox.Show("Tạo tài khoản thành công");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tài khoản đã tồn tại");

                }
               
            }
        }

        private void gCThanhVien_Click(object sender, EventArgs e)
        {
            string soThe = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SOTHE").ToString();
            string maNV = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MANV").ToString();
            string maKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
            string ngayCap = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NGAYCAP").ToString();
            txtsothe.Text = soThe;
            cbomanv.Text = maNV;
            txtngaycap.Text = ngayCap;
            txtmakh.Text = maKH;


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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Show();
            //this.Hide();
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtsothe.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tài khoản muôn xóa!");
            }
            else
            {
                 if (MessageBox.Show("Bạn muốn xóa tài khoản này không này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                             gCThanhVien.DataSource=xl.deleteTKTV(txtsothe.Text);
                             gCThanhVien.DataSource = xl.getTV();
                             MessageBox.Show("Xóa thành công");
                        }
            }
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.Show();
            this.Hide();
        }    
    }
}
