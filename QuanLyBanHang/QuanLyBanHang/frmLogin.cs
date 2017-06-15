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
using BUS;

namespace QuanLyBanHang
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

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
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            String ps = GetMD5(txtMatKhau.Text);
            var check = BUS.QuanLyBanHangBUS.DangNhap(txtTenDangNhap.Text.Trim(), ps);
            if (check == null)
            {
                MessageBox.Show("Đăng nhập thất bại ", ps);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain frm = new frmMain(check.Id);
                frm.Show();
                this.Hide();
            }
        }
    }
}
