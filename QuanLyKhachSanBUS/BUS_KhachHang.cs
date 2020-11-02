using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanBUS;
using QuanLyKhachSanDAL;
using QuanLyKhachSanEmtyti;
namespace QuanLyKhachSanBUS
{
    public class BUS_KhachHang
    {
        readonly SQL_KhachHang sql = new SQL_KhachHang();
       
        public void ThemDuLieu(EC_KhachHang ec)
        {
            sql.ThemDuLieu(ec);

        }
        public DataTable TaoBang(string DieuKhien)
        {
            return sql.TaoBang(DieuKhien);
        }
        public int XoaduLieu(EC_KhachHang ec)
        {
            return this.sql.XoaDulieu(ec);
        }
        public void SuaDuLieu(EC_KhachHang ec)
        {
            sql.SuaDuLieu(ec);
        }
    }
}
