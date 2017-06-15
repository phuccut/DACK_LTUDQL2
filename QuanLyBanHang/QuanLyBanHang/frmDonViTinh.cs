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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            List<DonViTinh> dvt = new List<DonViTinh>();
            dvt = BUS.QuanLyBanHangBUS.GetDonViTinh();
            gcDuLieu.DataSource = dvt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmKhuVucThem f = new frmKhuVucThem();
            f.ShowDialog();
            frmDonViTinh_Load(e,e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhuVuc kv = new KhuVuc();
            if (dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "Id") != null)
                kv.Id = dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "Id").ToString();
            if (dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "Ten") != null)
                kv.Ten = dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "Ten").ToString();
            if (dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "MoTa") != null )
                kv.MoTa = dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "MoTa").ToString();
            kv.QuanLy = bool.Parse(dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "QuanLy").ToString());
            frmKhuVucSua f = new frmKhuVucSua(kv);
            f.ShowDialog();
            frmDonViTinh_Load(e, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn xóa ?", "Xóa", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }else
            {
                String id = dgvDonViTinh.GetRowCellValue(dgvDonViTinh.FocusedRowHandle, "Id").ToString();
                BUS.QuanLyBanHangBUS.XoaKhuVuc(id);
                MessageBox.Show("Đã xóa thành công");
                frmDonViTinh_Load(e,e);
            }
        }
    }
}