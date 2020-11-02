using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanDAL;
using QuanLyKhachSanEmtyti;


namespace QuanLyKhachSanBUS
{
     public class BUS_NhanPhong
    {
        readonly SQL_NhanPhong sql = new SQL_NhanPhong();
        public void ThemDuLieu(EC_NhanPhong ec)
        {
            sql.Themdulieu(ec);

        }
        public DataTable TaoBang(string Dieukhien)
        {
            return sql.TaoBang(Dieukhien);
        }
        public void XoaduLieu(EC_NhanPhong ec)
        {
            sql.XoaDulieu(ec);
        }
        public void SuaDuLieu(EC_NhanPhong ec)
        {
            sql.SuaDuLieu(ec);
        }
    }
}
