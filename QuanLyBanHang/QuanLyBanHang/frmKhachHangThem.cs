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
    public partial class frmKhachHangThem : Form
    {
        public frmKhachHangThem()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Ten = txtTenKhachHang.Text.ToString();
            kh.Id = txtMaKhachHang.Text.ToString();
            kh.IdKhuVuc = txtMaKhuVuc.Text.ToString();
            kh.LienHe = txtNguoiLienHe.Text.ToString();
            kh.DienThoai = txtDienThoai.Text.ToString();
            kh.DiDong = txtDiDong.Text.ToString();
            kh.Website = txtWebsite.Text.ToString();
            if (txtSoTaiKhoan.Text != null)
            {
                kh.SoTaiKhoan = int.Parse(txtSoTaiKhoan.Text.ToString());
            }
            kh.TenNganHang = txtTenNganHang.Text.ToString();
            kh.QuanLy = cQuanLy.Checked;
            BUS.QuanLyBanHangBUS.ThemKhachHang(kh);
            MessageBox.Show("Đã thêm khách hàng thành công", "Thành công");
            this.Close();
        }
    }
}
