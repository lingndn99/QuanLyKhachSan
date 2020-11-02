using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSanEmtyti
{
    public class EC_Phong
    {
        private string _Maphong;
        private string _Tenphong;
        private string _Loaiphong;
        private float _Gia;
        private string _Tinhtrang;
        private string _Status;

        public string Maphong
        {
            get { return _Maphong; }
            set { _Maphong = value; }
        }
        public string Tenphong
        {
            get { return _Tenphong; }
            set { _Tenphong = value; }
        }
        public string Loaiphong
        {
            get { return _Loaiphong; }
            set { _Loaiphong = value; }
        }
        public float Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }
        public string Tinhtrang
        {
            get { return _Tinhtrang; }
            set { _Tinhtrang = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        
    }
        
}
