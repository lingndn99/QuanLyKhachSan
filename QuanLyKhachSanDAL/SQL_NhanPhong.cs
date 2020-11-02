using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;


namespace QuanLyKhachSanDAL
{
   public class SQL_NhanPhong
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void Themdulieu(EC_NhanPhong ec)
        {
            cn.ThucHienCauLenh("INSERT INTO NhanPhong1 (MaPhieuDKy, MaPhieuNhan, MaPhong, TenKhach, SDT, CMND, DiaChi, NgayNhan, NgayTra)VALUES(N'"+ec.MaDky+"', N'"+ec.MaPhieu+"', N'"+ec.MaPhong+"', N'"+ec.TenKhach+"', N'"+ec.SDT+"', N'"+ec.CMND+"', N'"+ec.DiaChi+"', '"+ec.NgayNhan+"', '"+ec.NgayTra+"')");
        }
        public DataTable TaoBang(string Dieukhien)
        {
            return cn.LayDuLieuBang(Dieukhien);
        }
        public int XoaDulieu(EC_NhanPhong ec)
        {
          return  cn.Query("delete from NhanPhong1 where MaPhieuNhan = '" + ec.MaPhieu + "'");
        }
        public void SuaDuLieu(EC_NhanPhong ec)
        {
            cn.ThucHienCauLenh("UPDATE NhanPhong1 SET  MaPhieuDky = '" + ec.MaDky + "', TenKhach = '" + ec.TenKhach + "', SDT = '" + ec.SDT + "',MaPhong='" + ec.MaPhong + "',CMND='" + ec.CMND + "',DiaChi='" + ec.DiaChi + "',NgayNhan='" + ec.NgayNhan + "',NgayTra='" + ec.NgayTra + "' WHERE   MaPhieuDky = '" + ec.MaPhieu + "'");
        }

    }
}
