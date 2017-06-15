using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyBanHang
{
    public partial class frmKhachHangSua : Form
    {
        public frmKhachHangSua()
        {
            InitializeComponent();
        }

        public KhachHang khachhang;

        public frmKhachHangSua(KhachHang kh):this()
        {
            khachhang = kh;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ten = txtTenKhachHang.Text.ToString();
            kh.Id = txtMaKhachHang.Text.ToString();
            kh.IdKhuVuc = txtMaKhuVuc.Text.ToString();
            kh.LienHe = txtNguoiLienHe.Text.ToString();
            kh.DienThoai = txtDienThoai.Text.ToString();
            kh.DiDong = txtDiDong.Text.ToString();
            kh.Website = txtWebsite.Text.ToString();
            if (txtSoTaiKhoan.Text != "")
            {
                kh.SoTaiKhoan = int.Parse(txtSoTaiKhoan.Text.ToString());
            }
            kh.TenNganHang = txtTenNganHang.Text.ToString();
            kh.QuanLy = cQuanLy.Checked;
            BUS.QuanLyBanHangBUS.SuaKhachHang(kh);
            MessageBox.Show("Đã sửa khách hàng thành công", "Thành công");
            this.Close();
        }

        private void frmKhachHangSua_Load(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = khachhang.Id;
            txtMaKhuVuc.Text = khachhang.IdKhuVuc;
            txtTenKhachHang.Text = khachhang.Ten;
            txtNguoiLienHe.Text = khachhang.LienHe;
            txtDienThoai.Text = khachhang.DienThoai;
            txtDiDong.Text = khachhang.DiDong;
            txtWebsite.Text = khachhang.Website;
            txtSoTaiKhoan.Text = khachhang.SoTaiKhoan.ToString() ;
            txtTenNganHang.Text = khachhang.TenNganHang;
            cQuanLy.Checked = khachhang.QuanLy.Value;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
