using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyBanHangDTO
    {
        public class ThongTin
        {
            public String TenDonVi { get; set; }
            public String DiaChi { get; set; }
            public String DienThoai { get; set; }
            public String Fax { get; set; }
            public String Email { get; set; }
            public String Website { get; set; }
            public String IdLinhVuc { get; set; }
            public int MaSoThue { get; set; }
            public int GPKD { get; set; }
        }
        public class LinhVuc
        {
            public string Id { get; set; }
            public string Ten { get; set; }
        }
    }
}
