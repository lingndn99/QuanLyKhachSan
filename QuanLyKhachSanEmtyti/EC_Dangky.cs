using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEmtyti
{
   public class EC_Dangky
    {
        private string _Maphieu;
        private string _Maphong;
        private string _TenKhach;
        private string _SDT;
        private string _NgayDky;
        private string _Ngaynhan;

        public string Maphieu
        {
            get { return _Maphieu; }
            set { _Maphieu = value; }
        }
        public string Maphong
        {
            get { return _Maphong; }
            set { _Maphong = value; }
        }
        public string Tenkhach
        {
            get { return _TenKhach; }
            set { _TenKhach = value; }
        }
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        public string Ngaydky
        {
            get { return _NgayDky; }
            set { _NgayDky = value; }
        }
        public string Ngaynhan
        {
            get { return _Ngaynhan; }
            set { _Ngaynhan = value; }
        }
    }
}
