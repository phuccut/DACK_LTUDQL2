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
    public partial class frmKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhoHang()
        {
            InitializeComponent();
        }

        private void frmKhoHang_Load(object sender, EventArgs e)
        {
            List<KhoHang> kh = new List<KhoHang>();
            kh = BUS.QuanLyBanHangBUS.GetKhoHang();
            gcDuLieu.DataSource = kh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhuVucThem f = new frmKhuVucThem();
            f.ShowDialog();
            frmKhoHang_Load(e,e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhuVuc kv = new KhuVuc();
            if (dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "Id") != null)
                kv.Id = dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "Id").ToString();
            if (dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "Ten") != null)
                kv.Ten = dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "Ten").ToString();
            if (dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "MoTa") != null )
                kv.MoTa = dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "MoTa").ToString();
            kv.QuanLy = bool.Parse(dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "QuanLy").ToString());
            frmKhuVucSua f = new frmKhuVucSua(kv);
            f.ShowDialog();
            frmKhoHang_Load(e, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn xóa ?", "Xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }else
            {
                String id = dgvKhoHang.GetRowCellValue(dgvKhoHang.FocusedRowHandle, "Id").ToString();
                BUS.QuanLyBanHangBUS.XoaKhuVuc(id);
                MessageBox.Show("Đã xóa thành công");
                frmKhoHang_Load(e,e);
            }
        }
    }
}