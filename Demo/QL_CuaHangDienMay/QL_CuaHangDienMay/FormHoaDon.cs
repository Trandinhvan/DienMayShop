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
using BLL;

namespace QL_CuaHangDienMay
{
    public partial class FormHoaDon : Form
    {
        BLL_TaoHoaDon taoHoaDon = new BLL_TaoHoaDon();
        XuLy xl = new XuLy();
        double thanhtien;
        double tongTien;
        double TongBill;
        public FormHoaDon()
        {
            InitializeComponent();
            
            cb_loaiSP.DataSource = xl.GetLoaiSanPham();
            cb_loaiSP.SelectedIndex = 1;
            cb_loaiSP.DisplayMember = "MaLoai";
            cb_loaiSP.ValueMember = "MaLoai";
            cb_SP.DataSource = xl.GetSP();
            cb_SP.DisplayMember = "TenSanPham";
            cb_SP.ValueMember = "MaSanPham";
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
                FormDangNhap frmDangNhap = new FormDangNhap();
                frmDangNhap.ShowDialog();
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {

            dgv_cthd.Refresh();
            DateTime Now=DateTime.Now;
            if (taoHoaDon.kiemTraMaHoaDon(txt_maHD.Text))
            {
                taoHoaDon.insertChiTietHD(txt_maHD.Text, cb_SP.SelectedValue.ToString(), int.Parse(number_sl.Value.ToString()), int.Parse(txt_donGia.Text), double.Parse(txt_ThanhTien.Text), "12");
                dgv_cthd.DataSource = taoHoaDon.loadChiTietHD(txt_maHD.Text);
                txt_maHD.ReadOnly = true;
                txt_NhaVienLap.ReadOnly = true;
                txt_MaKH.ReadOnly = true;
                tongTien += thanhtien;
                txt_tongtien.Text = tongTien.ToString();
                taoHoaDon.updateHoaDon(txt_MaKH.Text, int.Parse(tongTien.ToString()), txt_maHD.Text);
            }
            else
            {
                tongTien = 0;
                taoHoaDon.insertHoaDon(txt_maHD.Text, txt_NhaVienLap.Text, Now, txt_MaKH.Text);
                MessageBox.Show("Tạo hóa đơn thành công");
                taoHoaDon.insertChiTietHD(txt_maHD.Text, cb_SP.SelectedValue.ToString(), int.Parse(number_sl.Value.ToString()), int.Parse(txt_donGia.Text),thanhtien, "12");
                dgv_cthd.DataSource = taoHoaDon.loadChiTietHD(txt_maHD.Text);
                txt_maHD.ReadOnly = true;
                txt_NhaVienLap.ReadOnly = true;
                txt_MaKH.ReadOnly = true;
                tongTien += thanhtien;
                txt_tongtien.Text = tongTien.ToString();
                taoHoaDon.updateHoaDon(txt_MaKH.Text, int.Parse(tongTien.ToString()), txt_maHD.Text);
            }
        }

        private void cb_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_SP.DataSource = xl.GetSanPham(cb_loaiSP.SelectedValue.ToString());
            cb_SP.DisplayMember = "TenSanPham";
            cb_SP.ValueMember = "MaSanPham";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            
            txt_maHD.ReadOnly = false;
            txt_NhaVienLap.ReadOnly = false;
            txt_MaKH.ReadOnly = false;
            txt_maHD.Text = string.Empty;
            txt_NhaVienLap.Text = string.Empty;
            txt_MaKH.Text = string.Empty;
        }

        private void number_sl_ValueChanged(object sender, EventArgs e)
        {
            thanhtien = 0;
            thanhtien = int.Parse(number_sl.Value.ToString()) * int.Parse(txt_donGia.Text);
            txt_ThanhTien.Text = thanhtien.ToString();
        }

        private void pd_HoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            TongBill = 0;
            DataTable hoaDon = new DataTable();
            hoaDon = taoHoaDon.loadChiTietHD(txt_maHD.Text);

            var w = pd_HoaDon.DefaultPageSettings.PaperSize.Width;
            //vẽ header của bill
            //1. tên cửa hàng (quán karaoke)
            e.Graphics.DrawString("CỬA HÀNG ĐIỆN MÁY ABC", new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(100, 20));
            e.Graphics.DrawString(String.Format("Mã Hóa Đơn:{0}", txt_maHD.Text), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 20));
            //2. địa chỉ và số điện thoại
            e.Graphics.DrawString(string.Format("{0} - {1}", "Tân Hiệp-Kiên Giang", "09099999999"), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(100, 45));
            e.Graphics.DrawString(String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 200, 45));
            //định dạng bút vẽ
            Pen blackPen = new Pen(Color.Black, 1);
            var y = 70;
            //định nghĩa 2 điểm để vẽ đường thẳng
            //cách lề trái 10, lề phải 10
            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);

            //kẻ đường thẳng thứ nhất
            e.Graphics.DrawLine(blackPen, p1, p2);
            y += 10;
            e.Graphics.DrawString("STT", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(10, y));
            e.Graphics.DrawString("Mã Mặt Hàng", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(50, y));
            e.Graphics.DrawString("SL", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
            e.Graphics.DrawString("Đơn giá", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
            e.Graphics.DrawString("Thành tiền", new Font("Courier New", 10, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
            y += 20;
            int i = 1;
            foreach (DataRow dr in hoaDon.Rows)
            {
                
                e.Graphics.DrawString(string.Format("{0}", i++), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(dr["MASANPHAM"].ToString(), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(50, y));
                e.Graphics.DrawString(string.Format("{0:N0}", dr["SOLUONG"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));
                e.Graphics.DrawString(string.Format("{0:N0}", dr["DONGIA"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2 + 100, y));
                e.Graphics.DrawString(string.Format("{0:N0}", dr["THANHTIEN"].ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));
                y += 20;
                TongBill += double.Parse(dr["THANHTIEN"].ToString());
            }
            y += 40;
            //set lại tọa độ cho 2 điểm để vẽ đường thẳng thứ 3
            y += 20;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            //tổng tiền thanh toán
            y += 20;
            e.Graphics.DrawString(string.Format("Tổng tiền: {0:N0} VNĐ", TongBill.ToString()), new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w - 200, y));

            y += 40;
            e.Graphics.DrawString("Xin chân thành cảm ơn sự ủng hộ của quý khách!", new Font("Courier New", 8, FontStyle.Bold), Brushes.Black, new Point(w / 2, y));


        }
        private void InHoaDon()
        {
            ppd_HoaDon.Document = pd_HoaDon;
            ppd_HoaDon.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void cb_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            data = xl.GetSanPham(cb_loaiSP.SelectedValue.ToString());
            foreach (DataRow dr in data.Rows)
            {

                if (dr["MaSanPham"].ToString().Equals(cb_SP.SelectedValue.ToString()))
                {
                    txt_donGia.Text = dr["GIA"].ToString();
                }
                
            }

        }

    }
}
