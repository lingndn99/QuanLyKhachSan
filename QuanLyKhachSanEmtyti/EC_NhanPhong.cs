using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

 namespace QuanLyKhachSanEmtyti
{
    public class EC_NhanPhong
    {
        private string _MaPhieu;
        private string _MaDky;
        private string _MaPhong;
        private string _TenKhach;
        private string _SDT;
        private string _CMND;
        private string _DiaChi;
        private string _NgayNhan;
        private string _NgayTra;

        public string MaPhieu { get => _MaPhieu; set => _MaPhieu = value; }
        public string MaDky { get => _MaDky; set => _MaDky = value; }
        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public string TenKhach { get => _TenKhach; set => _TenKhach = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string NgayNhan { get => _NgayNhan; set => _NgayNhan = value; }
        public string NgayTra { get => _NgayTra; set => _NgayTra = value; }
    }
}
