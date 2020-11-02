
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;
//using System.Text.RegularExpressions;

namespace QuanLyKhachSanDAL
{
  public  class KetNoiDB
    {
        public static SqlConnection connect;
        //mo ket noi;
        public void MoKetNoi()
        {
            if(KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            if (KetNoiDB.connect.State != ConnectionState.Open)       
                KetNoiDB.connect.Open();
            

        }
        //dong ket noi
        public void  DongKetNoi()
        {
            if(KetNoiDB.connect != null)
                if(KetNoiDB.connect.State == ConnectionState.Open)
                    KetNoiDB.connect.Close();
        }
        //thuc hien cau lenh
        public void ThucHienCauLenh(string txtSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(txtSQL, connect);
             
               cmd.ExecuteNonQuery();
                DongKetNoi();                   
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        //thuc hien lay du lieu bang
        public DataTable LayDuLieuBang(string txtSQL)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(txtSQL, connect);
                data.Fill(dt);
                return dt;

            }
            catch {  return null; }

        }
        //doc du lieu
        /*   public DataTable LoadDuLieu(string txtSQL)
           {
               try
               {
                   MoKetNoi();
                   DataTable dt = new DataTable();
                   SqlCommand cmd = new SqlCommand(txtSQL, connect);
                   SqlDataReader dr = cmd.ExecuteReader();
                //   dr.Fill(dt);


                   return dt;
               }
               catch { return null; }
           }*/
        //xoa du lieu
        public int Query(string sql)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.ExecuteNonQuery();
                DongKetNoi();
                return 0;
            }
            catch
            {
                return -1;
            }
        }

    }
}
