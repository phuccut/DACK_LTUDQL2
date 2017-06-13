using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLyBanHang
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        QuanLyBanHangDataContext db = new QuanLyBanHangDataContext();

        //Ma hoa MD5
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


        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            String ps = GetMD5(txtPassword.Password);
            var check = (from TaiKhoan in db.TaiKhoans
                         where TaiKhoan.TenTaiKhoan == txtUsername.Text.Trim() && TaiKhoan.MatKhau == ps
                         select TaiKhoan).SingleOrDefault();
            if (check == null)
            {
                MessageBox.Show("Đăng nhập thất bại ",ps);
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công");
                MainWindow frm = new MainWindow();
                frm.Show();
                this.Close();
            }
        }
    }
}
