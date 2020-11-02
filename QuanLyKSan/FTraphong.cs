using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanEmtyti;
using QuanLyKhachSanBUS;
using QuanLyKhachSanDAL;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QuanLyKSan
{
    public partial class FTraphong : Form
    {
        readonly BUS_HoaDon BUS = new BUS_HoaDon();
        readonly EC_HoaDon ec = new EC_HoaDon();
        readonly EC_Phong ec_phong = new EC_Phong();
        readonly BUS_Phong Phong = new BUS_Phong();
        public FTraphong()
        {
            InitializeComponent();
        }
        public void FunData2(string txthome)
        {

            txtphieunhan.Text = txthome;
            LoadPhieuNhan(txtphieunhan.Text);
            LoadGia(txtmaphong.Text);
        }
        public void FunData(TextBox txtFnhan)
        {
           
            txtphieunhan.Text = txtFnhan.Text;
            LoadPhieuNhan(txtphieunhan.Text);
            LoadGia(txtmaphong.Text);
        }
        void LoadPhieuNhan(string maphieu)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanPhong1 where MaPhieuNhan = '" + maphieu + "'", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtmaphong.Text = dr[2].ToString();
                txttenkhach.Text = dr[3].ToString();
                txtsdt.Text = dr[4].ToString();
                // txtngaynhan.Text = dr[4].ToString();
                datengaytt.Text = dr[8].ToString();
                connect.Close();
                LoadGia(txtmaphong.Text);
            }
            else
            {
                MessageBox.Show("Phiếu không tồn tại");
                connect.Close();
            }

        }
        void LoadGia(string maphong)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from Phong1 where MaPhong = '" + maphong + "'", connect);
            SqlDataReader dr1 = cmd.ExecuteReader();
            if (dr1.Read())
            {
                txtgia.Text = dr1[3].ToString();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Phiếu không tồn tại");
                connect.Close();
            }
            connect.Close();
        }
        void TraPhong()
        {
            string a = "trong";
            try
            {
                ec_phong.Maphong = txtmaphong.Text;
                ec_phong.Tinhtrang = a.ToString();
                ec_phong.Status = "0";
                Phong.DangKy(ec_phong);
               // MessageBox.Show("tra phong");
            }
            catch { MessageBox.Show("Lỗi trả phòng"); }
        }
        public static SqlConnection connect;
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaPhieuTT = txtphieutt.Text;
                ec.MaPhieuNhan = txtphieunhan.Text;
                ec.MaPhong = txtmaphong.Text;
                ec.TenKhach = txttenkhach.Text;
                ec.SDT = txtsdt.Text;
                ec.ThanhTien = float.Parse(txtgia.Text);
                ec.NgayTra = datengaytt.Value.ToString("yyyy-MM-dd");
              BUS.ThemDuLieu(ec);
               // connect = new SqlConnection(@"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                 // connect.Open();
                //  SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon(MaPhieuTT, MaPhieuNhan, MaPhong, TenKhach, SDT, ThanhTien, NgayTra) VALUES(N'" + ec.MaPhieuTT + "', N'" + ec.MaPhieuNhan + "', N'" + ec.MaPhong + "', N'" + ec.TenKhach + "', N'" + ec.SDT + "', " + ec.ThanhTien + ", '" + ec.NgayTra + "')  ", connect);
               // cmd.ExecuteNonQuery();
               // connect.Close();
                MessageBox.Show("thanh toan thanh cong");
                TraPhong();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());             
            }
        }

       
    }
}
