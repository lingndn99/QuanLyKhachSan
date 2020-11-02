using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;

namespace QuanLyKhachSanDAL
{
    public class SQL_Dangky
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void ThemPhieu(EC_Dangky ec)
        {
            cn.ThucHienCauLenh("INSERT INTO DangKy (MaPhieuDky, MaPhong, TenKhach, SDT, NgayDky, NgayNhan)VALUES(N'"+ec.Maphieu+"', N'"+ec.Maphong+"', N'"+ec.Tenkhach+"', N'"+ec.SDT+"', CONVERT(DATETIME, '"+ec.Ngaydky+"', 102), CONVERT(DATETIME, '"+ec.Ngaynhan+"', 102))");
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return cn.LayDuLieuBang(DieuKhien);
        }
        public DataTable Loadphieu( string maphieu )
        {
            string sql = "select * from DangKy where MaPhieuDky ='"+maphieu+"' ";
            return cn.LayDuLieuBang( sql);
        }
        public  int XoaDulieu(EC_Dangky ec)
        {
         return   cn.Query("delete from DangKy where MaPhieuDky = '" + ec.Maphieu + "'");
        }
        public void SuaDuLieu(EC_Dangky ec)
        {
            cn.ThucHienCauLenh("UPDATE DangKy SET  MaPhong = '" + ec.Maphong + "', TenKhach = '" + ec.Tenkhach + "', SDT = '" + ec.SDT + "',NgayDky='" + ec.Ngaydky + "',NgayNhan='"+ec.Ngaynhan+"' WHERE   MaPhieuDky = '" + ec.Maphieu + "'");
        }

    }
}
