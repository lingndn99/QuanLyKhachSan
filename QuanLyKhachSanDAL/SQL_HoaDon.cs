using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;

namespace QuanLyKhachSanDAL
{
    public class SQL_HoaDon
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void ThemPhieu(EC_HoaDon ec)
        {
            cn.ThucHienCauLenh("INSERT INTO HoaDon( MaPhieuNhan, MaPhong, TenKhach, SDT, ThanhTien, NgayTra) VALUES( N'" + ec.MaPhieuNhan + "', N'" + ec.MaPhong + "', N'" + ec.TenKhach + "', N'" + ec.SDT + "', " + ec.ThanhTien + ",  CONVERT(DATETIME, '"+ec.NgayTra+"', 102) )   ");
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return cn.LayDuLieuBang(DieuKhien);
        }
    }
}
