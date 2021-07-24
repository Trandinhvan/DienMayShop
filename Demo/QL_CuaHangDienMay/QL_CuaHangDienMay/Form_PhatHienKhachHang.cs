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
using System.Text.RegularExpressions;

namespace QL_CuaHangDienMay
{
    public partial class Form_PhatHienKhachHang : Form
    {
        public Form_PhatHienKhachHang()
        {
            InitializeComponent();
        }
        XuLy xuly =new XuLy();
        APINhanDien nhandien = new APINhanDien();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txTenDangNhap_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_PhatHienKhachHang_Load(object sender, EventArgs e)
        {
            RefreshMyForm();
            
            //timer1.Interval = 3000;
            //timer1.Tick += new System.EventHandler(timer1_Tick);
            //timer1.Start();
            
            
        }

        private void RefreshMyForm() {
            dgv_KhachHang.Refresh();
            String output = nhandien.getOutput();
            string[] words = output.Split(':');
            string[] words1 = words[1].Split(',');
            string strResult = Regex.Replace(words1[0], @"[^a-zA-Z0-9]", string.Empty);
            dgv_KhachHang.DataSource = xuly.getKHTheoMAKH(strResult.Trim());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshMyForm();
        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_KhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgv_KhachHang.CurrentRow.Selected = true;
                txt_tenKH.Text = dgv_KhachHang.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtSDT.Text = dgv_KhachHang.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txt_diaChi.Text = dgv_KhachHang.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                pictureBox1.Image = Image.FromFile(dgv_KhachHang.Rows[e.RowIndex].Cells[3].FormattedValue.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            }
        }

        

    }
}
