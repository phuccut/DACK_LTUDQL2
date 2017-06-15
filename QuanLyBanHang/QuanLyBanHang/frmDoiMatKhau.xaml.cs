using System;
using System.Collections.Generic;
using System.Linq;
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
using BUS;
using DTO;
using System.Security.Cryptography;

namespace QuanLyBanHang
{
    /// <summary>
    /// Interaction logic for frmDoiMatKhau.xaml
    /// </summary>
    public partial class frmDoiMatKhau : Window
    {
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
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        
        public frmDoiMatKhau(String id):this()
        {
            Id = id;
        }

        private void btnDoiMatKhau_Click(object sender, RoutedEventArgs e)
        {
            String psc = GetMD5(txtMatKhauCu.Password);
            String psm = GetMD5(txtMatKhauMoi.Password);
            if (BUS.TaiKhoanBUS.DoiMatKhau(Id, psc, psm) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công", "Thành công");
                this.Close();
            }else
            {
                MessageBox.Show("Sai mật khẩu cũ");
            }
        }

        private void btnHuy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
