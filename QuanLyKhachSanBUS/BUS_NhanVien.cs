using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;
using QuanLyKhachSanDAL;
namespace QuanLyKhachSanBUS
{
   public class BUS_NhanVien
    {
        readonly SQL_NhanVien sql = new SQL_NhanVien();

        public void ThemDuLieu(EC_NhanVien ec)
        {
            sql.ThemDuLieu(ec);

        }
        public DataTable TaoBang(string DieuKhien)
        {
            return sql.TaoBang(DieuKhien);
        }
        public int XoaduLieu(EC_NhanVien ec)
        {
            return this.sql.XoaDulieu(ec);
        }
        public void SuaDuLieu(EC_NhanVien ec)
        {
            sql.SuaDuLieu(ec);
        }
    }
}
