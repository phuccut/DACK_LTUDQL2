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
    public partial class frmKhuVucThem : Form
    {
        public frmKhuVucThem()
        {
            InitializeComponent();  
        }

        private void frmKhuVucThem_Load(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhuVuc kv = new KhuVuc();
            kv.Id = txtMaKhuVuc.Text;
            kv.Ten = txtTenKhuVuc.Text;
            kv.MoTa = txtMoTa.Text;
            kv.QuanLy = cQuanLy.Checked;
            BUS.QuanLyBanHangBUS.ThemKhuVuc(kv);
            MessageBox.Show("Đã thêm khu vực thành công", "Thành công");
            this.Close();
        }
    }
}
