using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuanLyBanHang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String Id;

        public MainWindow()
        {
            InitializeComponent();     
        }

        public MainWindow(String id):this()
        {
            Id = id;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.Xpf.Bars.ItemClickEventArgs e)
        {
            frmDoiMatKhau f = new frmDoiMatKhau(Id);
            f.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thoát", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
