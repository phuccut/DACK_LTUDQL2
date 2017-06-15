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

        // KHU VỰC

        public static List<KhuVuc> GetKhuVuc()
        {
            dbDataContext db = new dbDataContext();
            var check = (from KhuVuc in db.KhuVucs select KhuVuc);
            if (check != null)
            {
                List<KhuVuc> lst = check.ToList();
                return lst;
            }
            else return null;
        }
        public static void ThemKhuVuc(KhuVuc kv)
        {
            dbDataContext db = new dbDataContext();
            db.KhuVucs.InsertOnSubmit(kv);
            db.SubmitChanges();
        }
        public static void SuaKhuVuc(KhuVuc kv)
        {
            dbDataContext db = new dbDataContext();
            KhuVuc khuvuc = db.KhuVucs.Single(KhuVuc => KhuVuc.Id == kv.Id);
            khuvuc.Ten = kv.Ten;
            khuvuc.MoTa = kv.MoTa;
            khuvuc.QuanLy = kv.QuanLy;
            db.SubmitChanges();
        }
        public static void XoaKhuVuc(String id)
        {
            dbDataContext db = new dbDataContext();
            KhuVuc khuvuc = db.KhuVucs.Single(KhuVuc => KhuVuc.Id == id);
            db.KhuVucs.DeleteOnSubmit(khuvuc);
            db.SubmitChanges();
        }

        //KHÁCH HÀNG
        public static List<KhachHang> GetKhachHang()
        {
            dbDataContext db = new dbDataContext();
            var check = (from KhachHang in db.KhachHangs select KhachHang);
            if (check != null)
            {
                List<KhachHang> lst = check.ToList();
                return lst;
            }
            else return null;
        }
        public static void ThemKhachHang(KhachHang kh)
        {
            dbDataContext db = new dbDataContext();
            db.KhachHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        public static void SuaKhachHang(KhachHang kh)
        {
            dbDataContext db = new dbDataContext();
            KhachHang khachhang = db.KhachHangs.Single(KhachHang => KhachHang.Id == kh.Id);
            khachhang.Id = kh.Id;
            khachhang.IdKhuVuc = kh.IdKhuVuc;
            khachhang.Ten = kh.Ten;
            khachhang.DiaChi = kh.DiaChi;
            khachhang.DiDong = kh.DiDong;
            khachhang.DienThoai = kh.DienThoai;
            khachhang.Website = kh.Website;
            khachhang.MaSoThue = kh.MaSoThue;
            khachhang.SoTaiKhoan = kh.SoTaiKhoan;
            khachhang.Fax = kh.Fax;
            khachhang.TenNganHang = kh.TenNganHang;
            khachhang.QuanLy = kh.QuanLy;
            khachhang.LienHe = kh.LienHe;
            db.SubmitChanges();
        }
        public static void XoaKhachHang(String id)
        {
            dbDataContext db = new dbDataContext();
            KhachHang khachhang = db.KhachHangs.Single(KhachHang => KhachHang.Id == id);
            db.KhachHangs.DeleteOnSubmit(khachhang);
            db.SubmitChanges();
        }
        //KHO HÀNG
        public static List<KhoHang> GetKhoHang()
        {
            dbDataContext db = new dbDataContext();
            var check = (from KhoHang in db.KhoHangs select KhoHang);
            if (check != null)
            {
                List<KhoHang> lst = check.ToList();
                return lst;
            }
            else return null;
        }
        public static void ThemKhoHang(KhoHang kh)
        {
            dbDataContext db = new dbDataContext();
            db.KhoHangs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        public static void SuaKhoHang(KhoHang kh)
        {
            dbDataContext db = new dbDataContext();
            KhoHang khohang = db.KhoHangs.Single(KhoHang => KhoHang.Id == kh.Id);
            db.SubmitChanges();
        }
        public static void XoaKhoHang(String id)
        {
            dbDataContext db = new dbDataContext();
            KhoHang khohang = db.KhoHangs.Single(KhoHang => KhoHang.Id == id);
            db.KhoHangs.DeleteOnSubmit(khohang);
            db.SubmitChanges();
        }
        //ĐƠN VỊ TÍNH
        public static List<DonViTinh> GetDonViTinh()
        {
            dbDataContext db = new dbDataContext();
            var check = (from DonViTinh in db.DonViTinhs select DonViTinh);
            if (check != null)
            {
                List<DonViTinh> lst = check.ToList();
                return lst;
            }
            else return null;
        }
        public static void ThemDonViTinh(DonViTinh kh)
        {
            dbDataContext db = new dbDataContext();
            db.DonViTinhs.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        public static void SuaDonViTinh(DonViTinh kh)
        {
            dbDataContext db = new dbDataContext();
            DonViTinh donvitinh = db.DonViTinhs.Single(DonViTinh => DonViTinh.Id == kh.Id);
            db.SubmitChanges();
        }
        public static void XoaDonViTinh(String id)
        {
            dbDataContext db = new dbDataContext();
            DonViTinh donvitinh = db.DonViTinhs.Single(DonViTinh => DonViTinh.Id == id);
            db.DonViTinhs.DeleteOnSubmit(donvitinh);
            db.SubmitChanges();
        }
        //NHÀ CUNG CẤP
        public static List<NhaCungCap> GetNhaCungCap()
        {
            dbDataContext db = new dbDataContext();
            var check = (from NhaCungCap in db.NhaCungCaps select NhaCungCap);
            if (check != null)
            {
                List<NhaCungCap> lst = check.ToList();
                return lst;
            }
            else return null;
        }
        public static void ThemNhaCungCap(NhaCungCap kh)
        {
            dbDataContext db = new dbDataContext();
            db.NhaCungCaps.InsertOnSubmit(kh);
            db.SubmitChanges();
        }
        public static void SuaNhaCungCap(NhaCungCap kh)
        {
            dbDataContext db = new dbDataContext();
            NhaCungCap nhacungcap = db.NhaCungCaps.Single(NhaCungCap => NhaCungCap.Id == kh.Id);
            db.SubmitChanges();
        }
        public static void XoaNhaCungCap(String id)
        {
            dbDataContext db = new dbDataContext();
            NhaCungCap nhacungcap = db.NhaCungCaps.Single(NhaCungCap => NhaCungCap.Id == id);
            db.NhaCungCaps.DeleteOnSubmit(nhacungcap);
            db.SubmitChanges();
        }
    }
}
