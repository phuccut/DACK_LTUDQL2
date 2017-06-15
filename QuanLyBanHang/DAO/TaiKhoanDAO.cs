using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static TaiKhoan DangNhap(String TenTaiKhoan, String MatKhau)
        {
            dbDataContext db = new dbDataContext();
            var check = (from TaiKhoan in db.TaiKhoans where TaiKhoan.TenTaiKhoan == TenTaiKhoan && TaiKhoan.MatKhau == MatKhau select TaiKhoan).SingleOrDefault();
            if (check != null)
            {
                return check;
            }
            else return null;
        }
        public static void DoiMatKhau(String id,String MatKhauCu, String MatKhauMoi)
        {
            dbDataContext db = new dbDataContext();
            TaiKhoan tk = db.TaiKhoans.Single(TaiKhoan => TaiKhoan.Id == id);
            tk.MatKhau = MatKhauMoi;
            db.SubmitChanges();
        }
        public static int CheckMatKhauCu(String id,String MatKhauCu)
        {
            dbDataContext db = new dbDataContext();
            var check = (from TaiKhoan in db.TaiKhoans where TaiKhoan.Id == id && TaiKhoan.MatKhau == MatKhauCu select TaiKhoan).SingleOrDefault();
            if (check != null)
            {
                return 1;
            }
            else
                return 0;
        }
    }
}
