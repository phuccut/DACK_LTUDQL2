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
    public partial class frmKhuVucSua : Form
    {
        public frmKhuVucSua()
        {
            InitializeComponent();  
        }

        public KhuVuc kvt;

        public frmKhuVucSua(KhuVuc kv):this()
        {
            kvt = kv;
        }

        private void frmKhuVucSua_Load(object sender, EventArgs e)
        {
            txtMaKhuVuc.Text = kvt.Id;
            txtTenKhuVuc.Text = kvt.Ten;
            txtMoTa.Text = kvt.MoTa;
            cQuanLy.Checked = kvt.QuanLy.Value;
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
            BUS.QuanLyBanHangBUS.SuaKhuVuc(kv);
            MessageBox.Show("Đã sửa khu vực thành công", "Thành công");
            this.Close();
        }
    }
}
