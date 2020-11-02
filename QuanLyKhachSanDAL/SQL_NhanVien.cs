using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;
using QuanLyKhachSanDAL;

namespace QuanLyKhachSanDAL
{
    public class SQL_NhanVien
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu(EC_NhanVien ec )
        {
            cn.ThucHienCauLenh("INSERT INTO NhanVien(TenNV, MaNV, NgaySinh, SDT, DiaChi, Email)VALUES(N'"+ec.TenNhanVien+"', N'"+ec.MaNhanVien+"', '"+ec.NgaySinh+"', N'"+ec.SDT+"', N'"+ec.DiaChi+"', N'"+ec.Email+"')");
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return cn.LayDuLieuBang(DieuKhien);
        }
        public int XoaDulieu(EC_NhanVien ec)
        {
            return this.cn.Query("delete from NhanVien where MaNV = '" + ec.MaNhanVien + "'");
        }
        public void SuaDuLieu(EC_NhanVien ec)
        {
            cn.ThucHienCauLenh("UPDATE NhanVien SET  TenNV = '" + ec.TenNhanVien + "', NgaySinh = '" + ec.NgaySinh + "', SDT = '" + ec.SDT + "',DiaChi='" + ec.DiaChi + "', Email='" + ec.Email + "' WHERE   MaNV = '" + ec.MaNhanVien + "'");
        }
    }
}
