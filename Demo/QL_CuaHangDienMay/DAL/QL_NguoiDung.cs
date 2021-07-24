using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CH_DienMay_Final1TableAdapters;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class QL_NguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.DA_CNPM_FINALConnectionString1 == string.Empty)
                return 1;// Chuỗi cấu hình không tồn tại
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.DA_CNPM_FINALConnectionString1);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0;// Kết nối thành công chuỗi cấu hình hợp lệ
            }
            catch
            {
                return 2;// Chuỗi cấu hình không phù hợp.
            }
        }
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
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from TaiKhoan where TenDangNhap='" + pUser + "' and MatKhau ='" + pPass + "'",
            Properties.Settings.Default.DA_CNPM_FINALConnectionString1);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 1;// User không tồn tại
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() ==
            "False")
            {
                return 0;// Không hoạt động
            }
            return 2;// Đăng nhập thành công
        }
        //public List<String> GetMaNhomNguoiDung(string TenDangNhap)
        //{
        //    List<string> kq = new List<string>();
        //    QuanLyNguoiDungNhomNguoiDungTableAdapter da = new QuanLyNguoiDungNhomNguoiDungTableAdapter();
        //    DataTable NguoiDung = da.GetDataByDK(TenDangNhap);
        //    for (int i = 0; i < NguoiDung.Rows.Count; i++)
        //    {
        //        kq.Add(NguoiDung.Rows[i].ItemArray[1].ToString());
        //    }
        //    return kq;
        //}
        //public DataTable GetMaManHinh(string MaNhomNguoiDung)
        //{
        //    QuanLyPhanQuyenTableAdapter da = new QuanLyPhanQuyenTableAdapter();
        //    return da.GetDataByDK(MaNhomNguoiDung);

        //}
    }
}
