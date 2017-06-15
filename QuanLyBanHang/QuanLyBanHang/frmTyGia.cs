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
    public partial class frmTyGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTyGia()
        {
            InitializeComponent();
        }

        private void frmTyGia_Load(object sender, EventArgs e)
        {
            List<TyGia> tg = new List<TyGia>();
            tg = BUS.QuanLyBanHangBUS.GetTyGia();
            gcDuLieu.DataSource = tg;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhuVucThem f = new frmKhuVucThem();
            f.ShowDialog();
            frmTyGia_Load(e,e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhuVuc kv = new KhuVuc();
            if (dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Id") != null)
                kv.Id = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Id").ToString();
            if (dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Ten") != null)
                kv.Ten = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Ten").ToString();
            if (dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "MoTa") != null )
                kv.MoTa = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "MoTa").ToString();
            kv.QuanLy = bool.Parse(dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "QuanLy").ToString());
            frmKhuVucSua f = new frmKhuVucSua(kv);
            f.ShowDialog();
            frmTyGia_Load(e, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn xóa ?", "Xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }else
            {
                String id = dgvKhuVuc.GetRowCellValue(dgvKhuVuc.FocusedRowHandle, "Id").ToString();
                BUS.QuanLyBanHangBUS.XoaKhuVuc(id);
                MessageBox.Show("Đã xóa thành công");
                frmTyGia_Load(e,e);
            }
        }
    }
}