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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace QL_CuaHangDienMay
{
    public partial class FormNhanVien : Form
    {
        XuLy xl = new XuLy();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txt_diachi.Text = txt_manv.Text = txt_sdt.Text = txt_tennv.Text = txtngasinh.Text = string.Empty;
            txt_sdt.Enabled = txt_tennv.Enabled = txtngasinh.Enabled = txt_manv.Enabled = txt_diachi.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_manv.Text == "" || txt_tennv.Text == "" || txtngasinh.Text == "" || txt_sdt.Text == "" || txt_diachi.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                }
                else
                {
                    xl.insertNV(txt_manv.Text, txt_tennv.Text, DateTime.Parse(txtngasinh.Text), txt_sdt.Text, txt_diachi.Text);
                    gridControl1.DataSource = xl.getNV();
                    MessageBox.Show("Thêm nhân viên thành công");
                    txt_sdt.Enabled = txt_tennv.Enabled = txtngasinh.Enabled = txt_manv.Enabled = txt_diachi.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại");
                txt_manv.Focus();
            }
        }

        private void btndktv_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = xl.getNV();
            txt_sdt.Enabled = txt_tennv.Enabled = txtngasinh.Enabled = txt_manv.Enabled = txt_diachi.Enabled = false;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            string maNV = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "MANV").ToString();
            string tenNV = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "TENNV").ToString();
            DateTime ngaySinh = DateTime.Parse(advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "NGAYSINH").ToString());
            string sDT = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "SDT").ToString();
            string diaChi = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "DCHI").ToString();
            txt_manv.Text = maNV;
            txt_tennv.Text = tenNV;
            txt_sdt.Text = sDT;
            txt_diachi.Text = diaChi;
            txtngasinh.Text = ngaySinh.ToString();
            txt_diachi.Enabled = txt_sdt.Enabled = true;
        }

        private void advBandedGridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            try
            {
                GridView view = sender as GridView;
                string maNV = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "MANV").ToString();
                string tenNV = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "TENNV").ToString();
                DateTime ngaySinh = DateTime.Parse(advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "NGAYSINH").ToString());
                string sDT = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "SDT").ToString();
                string diaChi = advBandedGridView1.GetRowCellValue(advBandedGridView1.FocusedRowHandle, "DCHI").ToString();

                if (view.IsNewItemRow(e.RowHandle))
                {
                    xl.insertNV(maNV, tenNV, ngaySinh, sDT, diaChi);
                    gridControl1.DataSource = xl.getNV();
                    MessageBox.Show("Thêm nhân viên thành công!");

                }
                else
                {
                    xl.updatetNV(sDT, diaChi, maNV);
                    gridControl1.DataSource = xl.getNV();
                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
            }
        }
    }
}
