using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class QuanLyBanHangBUS
    {
        public static TaiKhoan DangNhap(String TenDangNhap, String MatKhau)
        {
            return DAO.QuanLyBanHangDAO.DangNhap(TenDangNhap, MatKhau);
        }
        public static int DoiMatKhau(String id, String MatKhauCu, String MatKhauMoi)
        {
            if (DAO.QuanLyBanHangDAO.CheckMatKhauCu(id, MatKhauCu) == 1)
            {
                DAO.QuanLyBanHangDAO.DoiMatKhau(id, MatKhauCu, MatKhauMoi);
                return 1;
            }
            else
                return 0;
        }
        public static ThongTin GetThongTin()
        {
            return DAO.QuanLyBanHangDAO.GetThongTin();
        }
        public static void UpdateThongTin(ThongTin tttemp)
        {
            DAO.QuanLyBanHangDAO.UpdateThongTin(tttemp);
        }
        public static List<LinhVuc> GetLinhVuc()
        {
            return DAO.QuanLyBanHangDAO.GetLinhVuc();
        }
        //KHU VỰC
        public static List<KhuVuc> GetKhuVuc()
        {
            return DAO.QuanLyBanHangDAO.GetKhuVuc();
        }
        public static void ThemKhuVuc(KhuVuc kv)
        {
            DAO.QuanLyBanHangDAO.ThemKhuVuc(kv);
        }
        public static void SuaKhuVuc(KhuVuc kv)
        {
            DAO.QuanLyBanHangDAO.SuaKhuVuc(kv);
        }
        public static void XoaKhuVuc(String id)
        {
            DAO.QuanLyBanHangDAO.XoaKhuVuc(id);
        }
        //KHÁCH HÀNG
        public static List<KhachHang> GetKhachHang()
        {
            return DAO.QuanLyBanHangDAO.GetKhachHang();
        }
        public static void ThemKhachHang(KhachHang kv)
        {
            DAO.QuanLyBanHangDAO.ThemKhachHang(kv);
        }
        public static void SuaKhachHang(KhachHang kv)
        {
            DAO.QuanLyBanHangDAO.SuaKhachHang(kv);
        }
        public static void XoaKhachHang(String id)
        {
            DAO.QuanLyBanHangDAO.XoaKhachHang(id);
        }
        //KHO HÀNG
        public static List<KhoHang> GetKhoHang()
        {
            return DAO.QuanLyBanHangDAO.GetKhoHang();
        }
        public static void ThemKhoHang(KhoHang kh)
        {
            DAO.QuanLyBanHangDAO.ThemKhoHang(kh);
        }
        public static void SuaKhoHang(KhoHang kh)
        {
            DAO.QuanLyBanHangDAO.SuaKhoHang(kh);
        }
        public static void XoaKhoHang(String id)
        {
            DAO.QuanLyBanHangDAO.XoaKhoHang(id);
        }
    }
}
