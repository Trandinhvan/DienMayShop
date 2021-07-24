using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.CH_DienMay_Final1TableAdapters;
using System.Data;
namespace DAL
{
    public class TaoHoaDon
    {
        HOADONTableAdapter hoadon = new HOADONTableAdapter();
        CHITIETHDTableAdapter cthoaDon = new CHITIETHDTableAdapter();

        public bool insertHoaDon(string pMaHD,string pManv, DateTime pNgayLap, string pMakh)
        {
            hoadon.InsertHoaDon(pMaHD, pManv, pNgayLap, pMakh);
            return true;
        }
        public bool insertChiTietHoaDon(string pMaHD, string pMaSP, int pSL, int pDonGia, double pThanhTien, string pTGBH )
        {
            cthoaDon.InsertChiTietHoaDon(pMaHD, pMaSP, pSL, pDonGia, pThanhTien, pTGBH);
            return true;
        }
        public DataTable loadHoaDon()
        {
            return hoadon.GetData();
        }
        public DataTable loadChiTietTheomaHD(string pMaHD)
        {
            return cthoaDon.GetCTHDTheoMaHD(pMaHD);
        }
        public DataTable loadHD(string MaHD)
        {
            return hoadon.KiemTraKhoaChinh(MaHD);
        }
        public bool updateHoaDon(string SMAKH, int TONGTIEN, string MAHD)
        {
            hoadon.UpdateHoaDon(SMAKH, TONGTIEN, MAHD);
            return true;
        }
        
    }
}
