using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using DAL;

namespace BLL
{
    public class BLL_TaoHoaDon
    {
        TaoHoaDon Dll_TaoHoaDon = new TaoHoaDon();

        public bool insertHoaDon(string pMaHD,string pManv, DateTime pNgayLap,string pMakh)
        {
            Dll_TaoHoaDon.insertHoaDon(pMaHD, pManv, pNgayLap, pMakh);
            return true;
        }
        public bool insertChiTietHD(string pMaHD, string pMaSP,int pSL,int pDonGia,double pThanhTien,string pTGBH)
        {
            Dll_TaoHoaDon.insertChiTietHoaDon(pMaHD, pMaSP, pSL, pDonGia, pThanhTien, pTGBH);

            return true;
        }
        public bool kiemTraMaHoaDon(string MaHD)
        {
            if (Dll_TaoHoaDon.loadHD(MaHD).Rows.Count >= 1)
            {
                return true;
            }
            return false;

        }
        public DataTable loadChiTietHD(string maHD)
        {
            return Dll_TaoHoaDon.loadChiTietTheomaHD(maHD);
        }
        public DataTable LoadHoadown(string maHD)
        {
            return Dll_TaoHoaDon.loadHD(maHD);
        }
        public bool updateHoaDon(string SMAKH, int TONGTIEN, string MAHD)
        {
            Dll_TaoHoaDon.updateHoaDon(SMAKH, TONGTIEN, MAHD);
            return true;
        }
    }
}
