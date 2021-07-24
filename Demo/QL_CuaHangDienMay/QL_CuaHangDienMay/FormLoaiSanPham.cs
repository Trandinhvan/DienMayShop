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
    public partial class FormLoaiSanPham : Form
    {
        XuLy xl = new XuLy();
        public FormLoaiSanPham()
        {
            InitializeComponent();
            txtMaLoai.Focus();
        }

        private void FormLoaiSanPham_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = xl.GetLoaiSanPham();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if(xl.InsertLoaiSP(txtMaLoai.Text,txtTenLoai.Text))
            {
                
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == String.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm muốn xóa!");
            }
            else
            {
                try
                {
                    if (xl.Xoa_LoaiSp(txtMaLoai.Text))
                    {
                        FormLoaiSanPham_Load(sender, e);
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            } 
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaLoai").ToString();
            txtTenLoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenLoai").ToString();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (txtMaLoai.Text == String.Empty || txtTenLoai.Text == String.Empty )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                try
                {
                    if (xl.Sua_LoaiSp(txtMaLoai.Text,txtTenLoai.Text))
                    {
                        FormLoaiSanPham_Load(sender, e);
                        MessageBox.Show("Sửa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }  
        }
    }
}
