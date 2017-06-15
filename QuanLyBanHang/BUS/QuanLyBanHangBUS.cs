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
    }
}
