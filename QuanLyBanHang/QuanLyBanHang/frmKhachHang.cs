using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using System.Collections;

namespace QuanLyBanHang
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {               
            List<KhachHang> kh = new List<KhachHang>();
            kh = BUS.QuanLyBanHangBUS.GetKhachHang();
            gcKhachHang.DataSource = kh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHangThem f = new frmKhachHangThem();
            f.ShowDialog();
            frmKhachHang_Load(e,e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Id") != null)
                kh.Id = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Id").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "IdKhuVuc") != null)
                kh.IdKhuVuc = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "IdKhuVuc").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Ten") != null )
                kh.Ten = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Ten").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DiaChi") != null)
                kh.DiaChi = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DiaChi").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DienThoai") != null)
                kh.DienThoai = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DienThoai").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DiDong") != null)
                kh.DiDong = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "DiDong").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Website") != null)
                kh.Website = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Website").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "SoTaiKhoan") != null)
                kh.SoTaiKhoan = int.Parse(dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "SoTaiKhoan").ToString());
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "TenNganHang") != null)
                kh.TenNganHang = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "TenNganHang").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "MaSoThue") != null)
                kh.MaSoThue = int.Parse(dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "MaSoThue").ToString());
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Fax") != null)
                kh.Fax = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Fax").ToString();
            if (dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "LienHe") != null)
                kh.LienHe = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "LienHe").ToString();
            kh.QuanLy = bool.Parse(dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "QuanLy").ToString());
            frmKhachHangSua f = new frmKhachHangSua(kh);
            f.ShowDialog();
            frmKhachHang_Load(e, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn xóa ?", "Xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }else
            {
                String id = dgvKhachHang.GetRowCellValue(dgvKhachHang.FocusedRowHandle, "Id").ToString();
                BUS.QuanLyBanHangBUS.XoaKhachHang(id);
                MessageBox.Show("Đã xóa thành công");
                frmKhachHang_Load(e,e);
            }
        }

    }
}