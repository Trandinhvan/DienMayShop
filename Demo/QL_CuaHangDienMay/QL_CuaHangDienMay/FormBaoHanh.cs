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
    public partial class FormBaoHanh : Form
    {
        XuLy xl = new XuLy();
        public FormBaoHanh()
        {
            InitializeComponent();
        }

        private void gCPBH_Click(object sender, EventArgs e)
        {
            string maKH = gridView4.GetRowCellValue(gridView4.FocusedRowHandle, "MAKH").ToString();
            gCKhachHang.DataSource = xl.getKHTheoMAKH(maKH);
        }

        private void FormBaoHanh_Load(object sender, EventArgs e)
        {
            gCPBH.DataSource = xl.getPBH();
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
