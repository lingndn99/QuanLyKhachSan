using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanDAL;
using QuanLyKhachSanEmtyti;
namespace QuanLyKhachSanDAL
{
  public  class SQL_KhachHang
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu(EC_KhachHang ec)
        {
            cn.ThucHienCauLenh("INSERT INTO KhachHang ( TenKH, SDT, CMND, DiaChi) VALUES (N'"+ec.TenKhach+"', '"+ec.SDT+"', '"+ec.CMND+"', N'"+ec.DiaChi+"')");
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return cn.LayDuLieuBang(DieuKhien);
        }
        public int XoaDulieu(EC_KhachHang ec)
        {
            return this.cn.Query("delete from KhachHang where MaKH = '" + ec.MaKhachHang + "'");
        }
        public void SuaDuLieu(EC_KhachHang ec)
        {
            cn.ThucHienCauLenh("UPDATE KhachHang SET  TenKH = '" + ec.TenKhach + "', CMND = '" + ec.CMND + "', SDT = '" + ec.SDT + "',DiaChi='" + ec.DiaChi + "' WHERE   MaKH = '" + ec.MaKhachHang + "'");
        }
    }
}
