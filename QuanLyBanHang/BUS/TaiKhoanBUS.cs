using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        public static TaiKhoan DangNhap(String TenDangNhap, String MatKhau)
        {
            return DAO.TaiKhoanDAO.DangNhap(TenDangNhap, MatKhau);
        }
        public static int DoiMatKhau(String id, String MatKhauCu, String MatKhauMoi)
        {
            if (DAO.TaiKhoanDAO.CheckMatKhauCu(id, MatKhauCu) == 1)
            {
                DAO.TaiKhoanDAO.DoiMatKhau(id, MatKhauCu, MatKhauMoi);
                return 1;
            }
            else
                return 0;           
        }
    }
}
