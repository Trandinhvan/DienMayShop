using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;

namespace QL_CuaHangDienMay
{
    static class Program
    {
        public static string TenDN;
        
       /* public static Form1 frmMain = null;
        public static DangKy frmDangky = null;
        public static FormDangNhap frmDangNhap = null;*/
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            Application.Run(new FormBaoHanh());
        }
    }
}
