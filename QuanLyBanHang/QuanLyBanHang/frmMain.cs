using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public String Id;

        public frmMain(String id):this()
        {
            Id = id;
        }

        private bool FormDaTonTai(Form f)
        {
            foreach(var frmChild in MdiChildren)
            {
                if (frmChild.Name == f.Name)
                {
                    frmChild.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThongTin f = new frmThongTin();
            f.Size = this.Size;
            if (FormDaTonTai(f))
            {
                return;
            }
            f.MdiParent = this;
            f.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(Id);
            f.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thoát", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhuVuc f = new frmKhuVuc();
            f.Size = this.Size;
            if (FormDaTonTai(f))
            {
                return;
            }
            f.MdiParent = this;
            f.Show();
        }
    }
}
