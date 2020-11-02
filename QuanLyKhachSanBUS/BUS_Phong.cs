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
    public class BUS_Phong
    {
        readonly SQL_Phong sql = new SQL_Phong();
        public void ThemDuLieu(EC_Phong ec)
        {
            sql.ThemDuLieu(ec);

        }
        public DataTable TaoBang(string DieuKhien)
         {
            return sql.TaoBang(DieuKhien);
        }
        public int XoaduLieu(EC_Phong ec)
        {
           return this.sql.XoaDulieu(ec);
        }
        public void SuaDuLieu(EC_Phong ec)
        {
            sql.SuaDuLieu(ec);
        }
        public void DangKy(EC_Phong ec)
        {
            sql.DangKy(ec);
        }

    }
}
