using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyKhachSanEmtyti;



namespace QuanLyKhachSanDAL
{
    public class SQL_Phong
    {
        readonly KetNoiDB cn = new KetNoiDB();
        public void ThemDuLieu(EC_Phong ec)
        {
            cn.ThucHienCauLenh("INSERT INTO Phong1 (MaPhong, TenPhong, LoaiPhong, Gia, TinhTrang ) VALUES('" + ec.Maphong + "',N'" + ec.Tenphong + "',N'" + ec.Loaiphong + "',N'" + ec.Gia + "',N'" + ec.Tinhtrang + "')");
        }
        public DataTable TaoBang(string DieuKhien)
        {
            return cn.LayDuLieuBang(DieuKhien);
        }
        public int XoaDulieu(EC_Phong ec)
        {
          return  this.cn.Query("delete from Phong1 where MaPhong = '" + ec.Maphong + "'");
        }
        public void SuaDuLieu(EC_Phong ec)
        {
            cn.ThucHienCauLenh("UPDATE Phong1 SET  TenPhong = '" + ec.Tenphong + "', LoaiPhong = '" + ec.Loaiphong + "', Gia = '" + ec.Gia + "',TinhTrang='" + ec.Tinhtrang + "' WHERE   MaPhong = '" + ec.Maphong + "'");
        }
        public void DangKy(EC_Phong ec)
        { 
        cn.ThucHienCauLenh("UPDATE Phong1 SET TinhTrang='" + ec.Tinhtrang + "' ,status ='"+ec.Status+"' WHERE   MaPhong = '" + ec.Maphong +"'");
        }
    }

}
    







