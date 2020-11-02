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
    public class BUS_HoaDon
    {
        private readonly SQL_HoaDon sql = new SQL_HoaDon();
        public void ThemDuLieu(EC_HoaDon ec)
        {
            sql.ThemPhieu(ec);
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return sql.TaoBang(DieuKhien);
        }

    }
}
