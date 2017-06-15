using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QuanLyBanHangDAO
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
        public static void DoiMatKhau(String id, String MatKhauCu, String MatKhauMoi)
        {
            dbDataContext db = new dbDataContext();
            TaiKhoan tk = db.TaiKhoans.Single(TaiKhoan => TaiKhoan.Id == id);
            tk.MatKhau = MatKhauMoi;
            db.SubmitChanges();
        }
        public static int CheckMatKhauCu(String id, String MatKhauCu)
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

        public static ThongTin GetThongTin()
        {
            dbDataContext db = new dbDataContext();
            var check = (from ThongTin in db.ThongTins select ThongTin).SingleOrDefault();
            if (check != null)
            {
                return check;
            }
            else return null;
        }

        public static void UpdateThongTin(ThongTin tttemp)
        {
            dbDataContext db = new dbDataContext();
            ThongTin tt = db.ThongTins.Single(ThongTin => ThongTin.Id == 1);
            tt.TenDonVi = tttemp.TenDonVi;
            tt.DiaChi = tttemp.DiaChi;
            tt.Email = tttemp.Email;
            tt.Fax = tttemp.Fax;
            tt.GPKD = tttemp.GPKD;
            tt.Website = tttemp.Website;
            tt.DienThoai = tttemp.DienThoai;
            tt.MaSoThue = tttemp.MaSoThue;
            tt.IdLinhVuc = tttemp.IdLinhVuc;
            db.SubmitChanges();
        }

        public static List<LinhVuc> GetLinhVuc()
        {
            dbDataContext db = new dbDataContext();
            var check = (from LinhVuc in db.LinhVucs select LinhVuc);
            if (check != null)
            {
                List<LinhVuc> lst = check.ToList();
                return lst;
            }
            else return null;
        }

    }
}
