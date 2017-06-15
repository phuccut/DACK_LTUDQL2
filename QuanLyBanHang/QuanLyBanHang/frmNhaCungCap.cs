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
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {               
            List<NhaCungCap> ncc = new List<NhaCungCap>();
            ncc = BUS.QuanLyBanHangBUS.GetNhaCungCap();
            gcData.DataSource = ncc;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhachHangThem f = new frmKhachHangThem();
            f.ShowDialog();
            frmNhaCungCap_Load(e,e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Id") != null)
                kh.Id = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Id").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "IdKhuVuc") != null)
                kh.IdKhuVuc = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "IdKhuVuc").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Ten") != null )
                kh.Ten = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Ten").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DiaChi") != null)
                kh.DiaChi = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DiaChi").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DienThoai") != null)
                kh.DienThoai = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DienThoai").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DiDong") != null)
                kh.DiDong = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "DiDong").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Website") != null)
                kh.Website = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Website").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "SoTaiKhoan") != null)
                kh.SoTaiKhoan = int.Parse(dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "SoTaiKhoan").ToString());
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "TenNganHang") != null)
                kh.TenNganHang = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "TenNganHang").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "MaSoThue") != null)
                kh.MaSoThue = int.Parse(dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "MaSoThue").ToString());
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Fax") != null)
                kh.Fax = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Fax").ToString();
            if (dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "LienHe") != null)
                kh.LienHe = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "LienHe").ToString();
            kh.QuanLy = bool.Parse(dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "QuanLy").ToString());
            frmKhachHangSua f = new frmKhachHangSua(kh);
            f.ShowDialog();
            frmNhaCungCap_Load(e, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn xóa ?", "Xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }else
            {
                String id = dgvNhaCungCap.GetRowCellValue(dgvNhaCungCap.FocusedRowHandle, "Id").ToString();
                BUS.QuanLyBanHangBUS.XoaKhachHang(id);
                MessageBox.Show("Đã xóa thành công");
                frmNhaCungCap_Load(e,e);
            }
        }

    }
}