using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmDoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        public frmDoiMatKhau(String id) : this()
        {
            Id = id;
        }


        public String Id;
        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }
        private void btnHoanTat_Click_1(object sender, EventArgs e)
        {
            String psc = GetMD5(txtMatKhauCu.Text);
            String psm = GetMD5(txtMatKhauMoi.Text);
            if (BUS.QuanLyBanHangBUS.DoiMatKhau(Id, psc, psm) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu cũ");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
