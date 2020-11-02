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
    public  class BUS_Dangky
    {
        private readonly SQL_Dangky sql = new SQL_Dangky();
        public void ThemDuLieu(EC_Dangky ec)
        {
            sql.ThemPhieu(ec);
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return sql.TaoBang(DieuKhien);
        }
        public DataTable Loadphieu(string maphieu)
        {
            return sql.Loadphieu(maphieu);
        }
        public void XoaduLieu(EC_Dangky ec)
        {
            sql.XoaDulieu(ec);
        }
        public void SuaDuLieu(EC_Dangky ec)
        {
            sql.SuaDuLieu(ec);
        }





    }
}
