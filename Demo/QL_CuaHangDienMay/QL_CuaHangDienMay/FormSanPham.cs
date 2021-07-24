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
    public partial class FormSanPham : Form
    {
        XuLy xl = new XuLy();
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            cbbLoai.DataSource = xl.GetLoaiSanPham();
            cbbLoai.SelectedIndex = 1;
            cbbLoai.DisplayMember = "MaLoai";
            cbbLoai.ValueMember = "MaLoai";
            gridControl1.DataSource = xl.GetSP();
            cbbNCC.DataSource = xl.GetNCC();
            cbbNCC.DisplayMember = "MaNCC";
            cbbNCC.ValueMember = "MaNCC";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           gridControl1.DataSource = xl.GetSanPham(cbbLoai.SelectedValue.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSanPham").ToString();
            txtTenSP.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenSanPham").ToString();
            cbbLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLoai").ToString();
            cbbNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNCC").ToString();
            txtDVT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DVT").ToString();
            txtGia.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GIA").ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text == String.Empty || txtTenSP.Text == String.Empty || cbbLoai.Text == String.Empty || cbbNCC.Text == String.Empty || txtGia.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                try
                {
                    if(xl.ThemSP(txtMaSP.Text,txtTenSP.Text,cbbLoai.Text,cbbNCC.Text,txtDVT.Text,int.Parse(txtGia.Text)))
                    {
                        FormSanPham_Load(sender, e);
                        MessageBox.Show("Thêm thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }  
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            foreach (char ch in txtGia.Text)
            {
                if (char.IsDigit(ch) == false)
                {
                    this.errorProvider1.SetError(ctr, "Bạn phải nhập số vào");
                    txtGia.Clear();

                }
                else
                {
                    this.errorProvider1.Clear();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            if (txtMaSP.Text == String.Empty || txtTenSP.Text == String.Empty || cbbLoai.Text == String.Empty || cbbNCC.Text == String.Empty || txtGia.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                try
                {
                    if (xl.CapNhat_SanPham(txtMaSP.Text, txtTenSP.Text, cbbLoai.Text, cbbNCC.Text, txtDVT.Text, int.Parse(txtGia.Text)))
                    {
                        FormSanPham_Load(sender, e);
                        MessageBox.Show("Sửa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }  
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm muốn xóa!");
            }
            else
            {
                try
                {
                    if (xl.Xoa_SanPham(txtMaSP.Text))
                    {
                        FormSanPham_Load(sender, e);
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

    }
}
