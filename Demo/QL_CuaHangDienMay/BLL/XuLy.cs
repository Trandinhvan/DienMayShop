using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BLL
{
  public  class XuLy
    {
        LoadData loadBLL = new LoadData();
        /*public bool kiemTraTrungSoThe(string psothe)
        {
            loadBLL.getTKTheoMa(psothe);
            return true;

        }*/
        
      //thêm khách hàng
        public bool InsertKH(string pmaKH, string ptenKH,string pdiaChi,string psDT)
        {
            loadBLL.InsertKH(pmaKH, ptenKH, pdiaChi, psDT);
            return true;
        }
      //thêm tài khoản thành viên
        public bool InsertTktv(string psoThe, string pmaNV,string pmaKH,DateTime pngayCap)
        {
            loadBLL.InsertTktv(psoThe, pmaNV,pmaKH,pngayCap);
            return true;
        }

      //Loai san pham
        public DataTable GetLoaiSanPham()
        {
           return loadBLL.LoadLoaiSanPham();
        }
        public bool InsertLoaiSP(string pMaloai, string pTenLoai)
        {
            loadBLL.InsertLoaiSp(pMaloai, pTenLoai);
            return true;
        }

        //Sản phẩm.
        public DataTable GetSanPham(string pMaLoai)
        {
           return loadBLL.LoadSanPham(pMaLoai); 
        }
        public DataTable GetSP()
        {
            return loadBLL.LoadSP();
        }
        public bool ThemSP(string pMaSp,string pTensp,string pMaloai,string pMancc,string pDvt,int pGia)
        {
             loadBLL.ThemSP(pMaSp, pTensp, pMaloai, pMancc, pDvt, pGia);
             return true;
        }

        
        public DataTable GetNCC()
        {
            return loadBLL.LoadNCC();
        }
        public bool CapNhat_SanPham(string pMaSp,string pTensp,string pMaloai,string pMaNcc,string pDVt,int pGia)
        {
            loadBLL.CapNhat_SanhPham(pMaSp, pTensp, pMaloai, pMaNcc, pDVt, pGia);
            return true;
        }
        public bool Xoa_SanPham(string pMasp)
        {
            loadBLL.Xoa_SanPham(pMasp);
            return true;
        }
        public bool Xoa_LoaiSp(string pMaloai)
        {
            loadBLL.DeleteLoaiSp(pMaloai);
            return true;
        }
        public bool Sua_LoaiSp(string pMaloai,string pTenloai)
        {
            loadBLL.UpdateLoaiSp(pMaloai, pTenloai);
            return true;
        }

        
        //
        //Lấy dữ liệu khách hàng load lên Gridcontrol
        public DataTable getKH()
        {
            return loadBLL.loadKH();

        }

        public DataTable getKHtheoMa(string makh)
        {
            return loadBLL.getKHTheoMAKH(makh);
        }
        //Lấy dữ liệu của tài khoản thành viên load lên Gridcontrol
        public DataTable getTV()
        {
            return loadBLL.loadTKTV();

        }
        //Lấy dữ liệu nhân viên load lên Gridcontrol
        public DataTable getNV()
        {
            return loadBLL.loadNV();

        }
        //Gọi lại hàm getTKTheoMaKH bên DAL 
        public DataTable getTKTheoMaKH(string pmaKH)
        {
            return loadBLL.getTKTheoMaKH(pmaKH);

        }
        //Gọi lại hàm lấy danh sách hóa đơn getHD bên DAL
        public DataTable getHD()
        {
            return loadBLL.getHD();
        }
        //Gọi lại hàm lchi tiết hóa đơn getCTHDTheoMaHD bên DAL
        public DataTable getCTHDTheoMaHD(string pmaHD)
        {
            return loadBLL.getCTHDTheoMaHD(pmaHD);
        }

        //Gọi lại hàm thêm loại sản phẩm InsertLoaiSp bên DAL
        //public bool InsertLoaiSP(string pMaloai, string pTenLoai)
        //{
        //    loadBLL.InsertLoaiSp(pMaloai, pTenLoai);
        //    return true;
        //}
        //Gọi lại hàm xóa loại sản phẩm DeleteLoaiSp bên DAL
        public bool DeleteLoaiSp(string pMaLoai, string pTenLoai)
        {
            loadBLL.DeleteLoaiSp(pMaLoai, pTenLoai);
            return true;
        }
        //Gọi làm hàm thêm khách hàng InsertKH bên DAL
        //public bool InsertKH(string pmaKH, string ptenKH, string pdiaChi, string psDT)
        //{
        //    loadBLL.InsertKH(pmaKH, ptenKH, pdiaChi, psDT);
        //    return true;
        //}
        //Gọi làm hàm thêm tài khoản thành viên InsertTktv bên DAL
        //public bool InsertTktv(string psoThe, string pmaNV, string pmaKH, DateTime pngayCap)
        //{
        //    loadBLL.InsertTktv(psoThe, pmaNV, pmaKH, pngayCap);
        //    return true;
        //}
        //Gọi làm hàm thêm chi tiết bảo hành InsertCTBH bên DAL
        public bool InsertCTBH(string pmaPBH, string pmaHD, string pmaSP, string ptinhTrang, float pdonGia, int psoLuong, float pthanhTien)
        {
            loadBLL.InsertCTBH(pmaPBH, pmaHD, pmaSP, ptinhTrang, pdonGia, psoLuong, pthanhTien);
            return true;
        }
        //Gọi làm hàm thêm phiếu bảo hành InsertPBH bên DAL
        public bool InsertPBH(string pmaPBH, string pmaNV, string pmaKH, DateTime pngayLap, int ptongTien)
        {

            loadBLL.InsertPBH(pmaPBH, pmaNV, pmaKH, pngayLap, ptongTien);
            return true;

        }
        //Gọi lại hàm cập nhật tổng tiền UpdateTongTienPBH bên DAL
        public bool UpdateTongTienPBH(string pmaPBH)
        {
            loadBLL.UpdateTongTienPBH(pmaPBH);
            return true;
        }
        //Gọi lại hàm lấy danh sach bảo hành getPBH bên DAL
        public DataTable getPBH()
        {
            return loadBLL.getPBH();
        }
        //Gọi lại hàm lấy danh sach chi tiết bảo hành getCTBH bên DAL
        public DataTable getCTBH()
        {
            return loadBLL.getCTBH();
        }
        //Gọi lại hàm lấy danh sach chi tiết bảo hành Theo mã phiếu bảo hành getCTBHTheoMaPBH bên DAL
        public DataTable getCTBHTheoMaPBH(string pmaPBH)
        {
            return loadBLL.getCTBHTheoMaPBH(pmaPBH);
        }
        //Gọi hàm xóa chi tiết bảo hành deleteCTBH bên DAL
        public bool deleteCTBH(string pmaPBH, string pmaHD, string pmaSP)
        {
            loadBLL.deleteCTBH(pmaPBH, pmaHD, pmaSP);
            return true;
        }
        //Gọi hàm xóa phiếu bảo hành deletePBH bên DAL
        public bool deletePBH(string pmaPBH)
        {
            loadBLL.deletePBH(pmaPBH);
            return true;
        }
        //Gọi lai hàm xóa đi tài khoản thành viên deleteTKTV bên DAL
        public bool deleteTKTV(string psoThe)
        {
            loadBLL.deleteTKTV(psoThe);
            return true;
        }
        //Gọi lại hàm lấy danh sách khách hàng theo mã khách hàng getKHTheoMAKH bên DAL
        public DataTable getKHTheoMAKH(string pmaKH)
        {
            return loadBLL.getKHTheoMAKH(pmaKH);
        }
        public bool insertNV(string pmaNV, string tenNV, DateTime ngaySinh, string sDT, string diaChi)
        {
            loadBLL.insertNV(pmaNV, tenNV, ngaySinh, sDT, diaChi);
            return true;
        }
        public bool updatetNV(string sDT, string diaChi, string pmaNV)
        {
            loadBLL.updatetNV(sDT, diaChi, pmaNV);
            return true;
        }

        public int? kiemTraQuyenDN(string tenDN, string mk)
        {
            return loadBLL.kiemTraQuyenDangNhap(tenDN, mk);
        }
    }
}
