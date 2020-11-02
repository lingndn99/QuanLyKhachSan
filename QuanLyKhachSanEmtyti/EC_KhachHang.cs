using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEmtyti
{
    public class EC_KhachHang
    {
        private string _MaKhachHang;
        private string _TenKhach;
        private string _SDT;
        private string _CMND;
        private string _DiaChi;

        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhach { get => _TenKhach; set => _TenKhach = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
    }
}
