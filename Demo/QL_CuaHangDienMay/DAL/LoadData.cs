using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using DAL.CuaHangDienMayTableAdapters;
//using DAL.CH_DienMay_FinalTableAdapters;
using DAL.CH_DienMay_Final1TableAdapters;

namespace DAL
{
    
   public class LoadData
    {
       LOAISANPHAMTableAdapter da_loaisp = new LOAISANPHAMTableAdapter();
       HOADONTableAdapter da_hd = new HOADONTableAdapter();
       CHITIETPHIEUBAOHANHTableAdapter da_ctbh = new CHITIETPHIEUBAOHANHTableAdapter();
       PHIEUBAOHANHTableAdapter da_pbh = new PHIEUBAOHANHTableAdapter();
       CHITIETHDTableAdapter da_cthd = new CHITIETHDTableAdapter();
       NHANVIENTableAdapter da_nv = new NHANVIENTableAdapter();
       KHACHHANGTableAdapter da_kh = new KHACHHANGTableAdapter();
       TAIKHOANTHANHVIENTableAdapter da_tktv = new TAIKHOANTHANHVIENTableAdapter();
       public DataTable LoadLoaiSanPham()
       {
           return da_loaisp.GetData();
       }
       SANPHAMTableAdapter da_sp = new SANPHAMTableAdapter();
       NHACUNGCAPTableAdapter da_ncc = new NHACUNGCAPTableAdapter();
       public DataTable LoadNCC()
       {
           return da_ncc.GetData();
       }
       
       //public DataTable loadTKTV()
       //{
       //    return da_tktv.GetData();
       //}
       
       //public DataTable loadKH()
       //{
       //    return da_kh.GetData();
       //}
       
       //public DataTable loadNV()
       //{
       //    return da_nv.GetData();
       //}
      /* public bool getTKTheoMa(string pSoThe)
       {
           da_tktv.GetDataDKSothe(pSoThe);
           return true;
     
       }*/
      //Xử lý loại sản phẩm.
       public bool InsertLoaiSp(string pMaLoai, string PTenLoai)
       {
           da_loaisp.Insert(pMaLoai, PTenLoai);
           return true;
       }
       public bool DeleteLoaiSp(string pMaLoai)
       {
           da_loaisp.DeleteQuery_LoaiSP(pMaLoai);
           return true;
       }

       public bool UpdateLoaiSp(string pMaLoai,string pTenLoai)
       {
           da_loaisp.UpdateQuery_LoaiSanPham(pTenLoai, pMaLoai);
           return true;
       }
       
       //thêm tài khoản thành viên
       //public bool InsertTktv(string psoThe, string pmaNV, string pmaKH, DateTime pngayCap)
       //{
       //    da_tktv.Insert(psoThe, pmaNV, pmaKH, pngayCap);
       //    return true;
       //}
       ////thêm khách hàng
       //public bool InsertKH(string pmaKH, string ptenKH, string pdiaChi, string psDT)
       //{
       //    da_kh.Insert(pmaKH, ptenKH, pdiaChi, psDT);
       //    return true;
       //}

       //sản phẩm.
       public DataTable LoadSanPham(string pMaLoai)
       {
          return da_sp.GetDataBy_SPTheoLoai(pMaLoai);
       }
       public DataTable LoadSP()
       {
           return da_sp.GetData();
       }
       public bool ThemSP(string pMaSP, string pTenSp, string pMaloai, string pMaNcc,string pDVT, int pgia)
       {
           da_sp.Insert(pMaSP, pTenSp, pMaloai, pMaNcc, pDVT, pgia);
           return true;
       }
       public bool CapNhat_SanhPham(string pMaSP,string pTenSP,string pMaloai,string pMaNCC, string pDVt,int pGia)
       {
           da_sp.UpdateQuery_SanPham(pTenSP, pMaloai, pMaNCC, pDVt, pGia, pMaSP);
           return true;
       }
       public bool Xoa_SanPham(string pMasp)
       {
           da_sp.DeleteQuery_SanPham(pMasp);
           return true;
       }

       /////

       //Lấy dữ liệu của tài khoản thành viên load lên Gridcontrol
       public DataTable loadTKTV()
       {
           return da_tktv.GetData();
       }
       //Lấy dữ liệu khách hàng load lên Gridcontrol
       public DataTable loadKH()
       {
           return da_kh.GetData();
       }
       public DataTable loadKHTheoMa(string MaKH)
       {
           return da_kh.GetKHTheoMAKH(MaKH);
       }
       //Lấy dữ liệu nhân viên load lên Gridcontrol
       public DataTable loadNV()
       {
           return da_nv.GetData();
       }
       //Lấy dữ liệu tài khoản thành viên theo mã khách hàng 
       //Viết hàm GetTKTheoMaKH trong dataset TAIKHOANTHANHVIEN
       public DataTable getTKTheoMaKH(string pmaKH)
       {
           return da_tktv.GetTKTheoMaKH(pmaKH);

       }

       //Lấy dữ liệu Hóa đơn load lên GridControl
       public DataTable getHD()
       {
           return da_hd.GetData();
       }
       //Lấy chi tiết hóa đơn theo mã hóa đơn
       //Viết hàm GetCTHDTheoMaHD trong dataset CHITIETHOADON
       public DataTable getCTHDTheoMaHD(string pmaHD)
       {
           return da_cthd.GetCTHDTheoMaHD(pmaHD);
       }
       //Thêm vào 1 loại sản phẩm
       //public bool InsertLoaiSp(string pMaLoai, string PTenLoai)
       //{
       //    da_loaisp.Insert(pMaLoai, PTenLoai);
       //    return true;
       //}
       public bool DeleteLoaiSp(string pMaLoai, string pTenLoai)
       {
           da_loaisp.Delete(pMaLoai, pTenLoai);
           return true;
       }
       //thêm tài khoản thành viên
       public bool InsertTktv(string psoThe, string pmaNV, string pmaKH, DateTime pngayCap)
       {
           da_tktv.Insert(psoThe, pmaNV, pmaKH, pngayCap);
           return true;
       }
       //Xóa 1 tài khoản thành viên 
       //Viết hàm xóa DeleteTKTV trong dataset TAIKHOANTHANHVIEN
       public bool deleteTKTV(string psoThe)
       {
           da_tktv.DeleteTKTV(psoThe);
           return true;
       }
       //thêm khách hàng
       public bool InsertKH(string pmaKH, string ptenKH, string pdiaChi, string psDT)
       {
           da_kh.Insert(pmaKH, ptenKH, pdiaChi, psDT);
           return true;
       }
       //thêm chi tiết bảo hành
       public bool InsertCTBH(string pmaPBH, string pmaHD, string pmaSP, string ptinhTrang, float pdonGia, int psoLuong, float pthanhTien)
       {
           da_ctbh.Insert(pmaPBH, pmaHD, pmaSP, ptinhTrang, pdonGia, psoLuong, pthanhTien);
           return true;
       }
       //Thêm 1 phiếu bảo hành 
       public bool InsertPBH(string pmaPBH, string pmaNV, string pmaKH, DateTime pngayLap, int ptongTien)
       {
           da_pbh.Insert(pmaPBH, pmaNV, pmaKH, pngayLap, ptongTien);
           return true;

       }
       //Update tổng tiền khi có nhiều thêm 1 chi tiết phiếu bảo hành mới
       //Viết hàm UpdateTongTienPBH trong dataset PHIEUBAOHANH
       public bool UpdateTongTienPBH(string pmaPBH)
       {
           da_pbh.UpdateTongTienPBH(pmaPBH);
           return true;
       }
       //Lấy dữ liệu phiếu bảo hành load lên gridcontrol
       public DataTable getPBH()
       {
           return da_pbh.GetData();
       }
       //Lấy dữ liệu chi tiết bảo hành load lên gridcontrol
       public DataTable getCTBH()
       {
           return da_ctbh.GetData();
       }
       //Lấy  chi tiết bảo hành theo mã phiếu bảo hành
       //Viết hàm GetCTBHTheoMAPBH trong dataset CHITIETPHIEUBAOHANH
       public DataTable getCTBHTheoMaPBH(string pmaPBH)
       {
           return da_ctbh.GetCTBHTheoMAPBH(pmaPBH);
       }
       //Xóa đi 1 chi tiết bảo hành
       //Viết hàm DeleteCTHD trong ndataset CHITIETPHIEUBAOHANH
       public bool deleteCTBH(string pmaPBH, string pmaHD, string pmaSP)
       {
           da_ctbh.DeleteCTHD(pmaPBH, pmaHD, pmaSP);
           return true;
       }
       //Xóa đi 1 phiếu bảo hành
       //Viết hàm DeletePBH trong dataset PHIEUBAOHANH
       public bool deletePBH(string pmaPBH)
       {
           da_pbh.DeletePBH(pmaPBH);
           return true;
       }

       //Lấy thông tin khách hàng khách hàng theo mã khách hàng
       public DataTable getKHTheoMAKH(string pmaKH)
       {
           return da_kh.GetKHTheoMAKH(pmaKH);
       }
       public bool insertNV(string pmaNV, string tenNV, DateTime ngaySinh, string sDT, string diaChi)
       {
           da_nv.Insert(pmaNV, tenNV, ngaySinh, sDT, diaChi);
           return true;
       }
       public bool updatetNV(string sDT, string diaChi, string pmaNV)
       {
           da_nv.UpdateNV(sDT, diaChi, pmaNV);
           return true;
       }

       TAIKHOANTableAdapter da_dn = new TAIKHOANTableAdapter();
       public int? kiemTraDangNhap(string tenDN, string mk)
       {
           return da_dn.ScalarQuery(tenDN, mk);
       }
       public int? kiemTraQuyenDangNhap(string tenDN, string mk)
       {
           return da_dn.ScalarQuery_PhanQuyen(tenDN, mk);
       }
    }
}
