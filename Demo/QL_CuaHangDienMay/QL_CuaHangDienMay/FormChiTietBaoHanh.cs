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
    public partial class FormChiTietBaoHanh : Form
    {
        XuLy xl = new XuLy();
        public FormChiTietBaoHanh()
        {
            InitializeComponent();
        }

        private void FormChiTietBaoHanh_Load(object sender, EventArgs e)
        {
            txtngaylap.Text = DateTime.Today.ToShortDateString();
            txtdongia.Enabled = false;
            txtmaKH.Enabled = false;
            txtmasp.Enabled = false;
            txtngaylap.Enabled = false;
            txtmahd.Enabled = false;
            gCHoaDon.DataSource = xl.getHD();
            cbomanv.DataSource = xl.getNV();
            cbomanv.DisplayMember = "MANV";
            gCPBH.DataSource = xl.getPBH();
            gCCTBH.DataSource = xl.getCTBH();
            btnxoa.Enabled = false;
        }

        private void cbotinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbotinhtrang.SelectedIndex == 1)
            {
                txtdongia.Enabled = true;
                txtdongia.Text = string.Empty;
            }
            else
            {
                txtdongia.Enabled = false;
                txtdongia.Text = "0";
            }
        }

        private void gCHoaDon_Click(object sender, EventArgs e)
        {
            txtmabaohanh.Text = "";
            txtmahd.Text = "";
            txtmasp.Text = "";
            cbomanv.Text = "";
            cbotinhtrang.Text = "";
            txtmaKH.Text = "";
            txtmasp.Text = "";
            txtdongia.Text = "";
            txtsoluong.Text = "";
            string maHD = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAHD").ToString();
            string maKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAKH").ToString();
            txtmaKH.Text = maKH;
            gCCTHD.DataSource = xl.getCTHDTheoMaHD(maHD);
        }

        private void gCCTHD_Click(object sender, EventArgs e)
        {
            string maHD = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MAHD").ToString();
            string maSP = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MASANPHAM").ToString();
            txtmahd.Text = maHD;
            txtmasp.Text = maSP;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txtmabaohanh.Text == string.Empty || txtmaKH.Text == string.Empty || cbomanv.Text == string.Empty || cbotinhtrang.Text == string.Empty || txtdongia.Text == string.Empty || txtsoluong.Text == string.Empty || txtmahd.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");
                return;
            }
            else
            {
                try
                {
                    try
                    {

                        gCPBH.DataSource = xl.InsertPBH(txtmabaohanh.Text, cbomanv.Text, txtmaKH.Text, DateTime.Parse(txtngaylap.Text), 0);
                        gCCTBH.DataSource = xl.InsertCTBH(txtmabaohanh.Text, txtmahd.Text, txtmasp.Text, cbotinhtrang.Text, float.Parse(txtdongia.Text), int.Parse(txtsoluong.Text), float.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text));

                    }
                    catch (Exception ex)
                    {
                        gCCTBH.DataSource = xl.InsertCTBH(txtmabaohanh.Text, txtmahd.Text, txtmasp.Text, cbotinhtrang.Text, float.Parse(txtdongia.Text), int.Parse(txtsoluong.Text), float.Parse(txtdongia.Text) * int.Parse(txtsoluong.Text));

                    }
                    xl.UpdateTongTienPBH(txtmabaohanh.Text);
                    gCPBH.DataSource = xl.getPBH();
                    gCCTBH.DataSource = xl.getCTBH();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Chi tiết bảo hành đã tồn tại");
                }


            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số vào !");
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Bạn chỉ được nhập số vào !");
            }
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            gCCTBH.DataSource = xl.getCTBH();
        }

        private void gCCTBH_Click(object sender, EventArgs e)
        {
            btnxoa.Enabled = true;
        }

        private void gCPBH_Click(object sender, EventArgs e)
        {
            string maPBH = gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "MAPBH").ToString();
            gCCTBH.DataSource = xl.getCTBHTheoMaPBH(maPBH);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = gridView3.FocusedRowHandle;
                string maPBH = "MAPBH";
                string maHD = "MAHD";
                string maSP = "MaSanPham";
                string value1 = (gridView3.GetRowCellValue(row_index, maPBH)).ToString();
                string value2 = gridView3.GetRowCellValue(row_index, maHD).ToString();
                string value3 = gridView3.GetRowCellValue(row_index, maSP).ToString();

                if (value1 == null || value2 == null || value3 == null)
                {
                    MessageBox.Show("Bạn chưa chọn chi tiết để xóa");
                }
                else
                {
                    try
                    {
                        if (MessageBox.Show("Bạn muốn xóa chi tiết này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            xl.deleteCTBH(value1, value2, value3);
                            xl.deletePBH(value1);


                        }
                    }
                    catch (Exception ex)
                    {
                        xl.deleteCTBH(value1, value2, value3);

                    }
                }
                xl.UpdateTongTienPBH(value1);
                gCPBH.DataSource = xl.getPBH();
                gCCTBH.DataSource = xl.getCTBH();
                btnxoa.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Danh sách không còn để xóa!");
            }
        }

        private void btnbaohanh_Click(object sender, EventArgs e)
        {
            FormBaoHanh bh = new FormBaoHanh();
            bh.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
