using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEmtyti
{
   public class EC_HoaDon
    {
        private string _MaPhieuTT;
        private string _MaPhieuNhan;
        private string _MaPhong;
        private string _TenKhach;
        private string _SDT;
        private float _ThanhTien;
        private string _NgayTra;

        public string MaPhieuTT { get => _MaPhieuTT; set => _MaPhieuTT = value; }
        public string MaPhieuNhan { get => _MaPhieuNhan; set => _MaPhieuNhan = value; }
        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public string TenKhach { get => _TenKhach; set => _TenKhach = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public float ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public string NgayTra { get => _NgayTra; set => _NgayTra = value; }
    }
}
