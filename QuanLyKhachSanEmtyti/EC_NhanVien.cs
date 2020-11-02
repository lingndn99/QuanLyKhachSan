using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEmtyti
{
   public class EC_NhanVien
    {
        private string _MaNhanVien;
        private string _TenNhanVien;
        private string _NgaySinh;
        private string _SDT;
        private string _DiaChi;
        private string _Email;

        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public string NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
