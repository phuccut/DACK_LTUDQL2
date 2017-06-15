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
namespace QuanLyBanHang
{
    public partial class frmThongTin : DevExpress.XtraEditors.XtraForm
    {
        public frmThongTin()
        {
            InitializeComponent();
        }

        private void frmThongTin_Load(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin();
            tt = BUS.QuanLyBanHangBUS.GetThongTin();
            txtTenDonVi.Text = tt.TenDonVi;
            txtDiaChi.Text = tt.DiaChi;
            txtEmail.Text = tt.Email;
            txtFax.Text = tt.Fax;
            txtGPKD.Text = tt.GPKD.ToString(); 
            txtWebsite.Text = tt.Website;
            txtSoDienThoai.Text = tt.DienThoai;
            txtMaSoThue.Text = tt.MaSoThue.ToString();
            lLinhVuc.Properties.DataSource = BUS.QuanLyBanHangBUS.GetLinhVuc();
            lLinhVuc.Properties.ValueMember = "Id";
            lLinhVuc.Properties.DisplayMember = "Ten";
            lLinhVuc.EditValue = tt.IdLinhVuc;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin();
            tt.Id = 1;
            tt.TenDonVi = txtTenDonVi.Text;
            tt.DiaChi = txtDiaChi.Text;
            tt.Email = txtEmail.Text;
            tt.Fax = txtFax.Text;
            tt.GPKD = int.Parse(txtGPKD.Text);
            tt.Website = txtWebsite.Text;
            tt.DienThoai = txtSoDienThoai.Text;
            tt.MaSoThue = int.Parse(txtMaSoThue.Text);
            tt.IdLinhVuc = lLinhVuc.EditValue.ToString();
            BUS.QuanLyBanHangBUS.UpdateThongTin(tt);
            MessageBox.Show("Cập nhật thông tin thành công","Thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}