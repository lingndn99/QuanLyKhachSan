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
using System.Data.SqlClient;

using System.Text.RegularExpressions;
using System.Xml;

namespace QuanLyKSan
{
    public partial class FDangkyphong : Form
    {
     
        readonly BUS_Dangky BUS = new BUS_Dangky();
        readonly BUS_Phong Phong = new BUS_Phong();
        readonly EC_Dangky ec = new EC_Dangky();
        readonly EC_Phong ec_phong = new EC_Phong();
        public KetNoiDB con = new KetNoiDB();

        public FDangkyphong()
        {
            InitializeComponent();
            Khoadieukhien();
         
        }
        
        public void FunData1(string txthome)
        {
            Modieukhien();
            txtmaphong.Items.Clear();
            txtmaphong.Items.Add(txthome);
            txtmaphong.DisplayMember= txthome;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
            btn_nhan.Enabled = false;


           
        }
        public void Loadcombobox()
        {
            txtmaphong.DataSource = BUS.TaoBang("Select MaPhong from Phong1 where TinhTrang LIKE'%Tr%'");
            txtmaphong.DisplayMember = "MaPhong";        
        }
        
        public void DangKyXong()
        {
            string a = "da dat";
           
            try
            {
                ec_phong.Maphong = txtmaphong.Text;
                ec_phong.Tinhtrang = a.ToString();
                ec_phong.Status = txtmaphieu.Text.ToString();

                Phong.DangKy(ec_phong);
                //  connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                //  connect.Open();
                // SqlCommand cmd = new SqlCommand("UPDATE Phong1 SET TinhTrang='" + ec_phong.Tinhtrang + "', status ='" + ec_phong.Status + "' WHERE   MaPhong = '" + ec_phong.Maphong + "'", connect);
                // cmd.ExecuteNonQuery();
                // connect.Close();
                //MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //MessageBox.Show("loi"); 
            }



        }
        public void Khoadieukhien()
        {
            txtmaphieu.Enabled = true;
            txtmaphong.Enabled = false;
            txtsdt.Enabled = false;
            txttenkhach.Enabled = false;
            date_dki.Enabled = false;
            date_nhan.Enabled = false;

           
            btndangky.Enabled = false;
            btn_nhan.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;
           

        }
        public void Modieukhien()
        {
            txtmaphieu.Enabled = true;
            txtmaphong.Enabled = true;
            txtsdt.Enabled = true;
            txttenkhach.Enabled = true;
            date_dki.Enabled = true;
            date_nhan.Enabled = true;

            btndangky.Enabled = true;
            btn_nhan.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;



        }
        public void Setnull()
        {
            txtmaphieu.Text = "";
            txtmaphong.Text = "";
            txttenkhach.Text = "";
            txtsdt.Text = "";
            
        }
         

        
        private void FDangkyphong_Load(object sender, EventArgs e)
        {
           //Khoadieukhien();
            Setnull();
            button2.Enabled = true;
        }
        public static SqlConnection connect;
        private void Btndangky_Click(object sender, EventArgs e)
        {
            try
            {
               // Modieukhien();
                ec.Maphieu = txtmaphieu.Text;
                ec.Maphong = txtmaphong.Text;
                ec.Tenkhach = txttenkhach.Text;
                ec.SDT = txtsdt.Text;
                ec.Ngaydky =  date_dki.Value.ToString("yyyy-MM-dd");
                ec.Ngaynhan =date_nhan.Value.ToString("yyyy-MM-dd");
                 BUS.ThemDuLieu(ec);
                  MessageBox.Show("Đăng Ký thành công");
                 DangKyXong();
                FDangkyphong_Load(sender, e);
                // connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                //  connect.Open();
                // SqlCommand cmd = new SqlCommand("INSERT INTO DangKy(MaPhieuDky, MaPhong, TenKhach, SDT, NgayDky, NgayNhan)VALUES(N'"+ec.Maphieu+"', N'"+ec.Maphong+"', N'"+ec.Tenkhach+"', N'"+ec.SDT+"',  '"+ec.Ngaydky+"',  '"+ec.Ngaynhan+"')", connect);
                // cmd.ExecuteNonQuery();
                // connect.Close();
                //con.DongKetNoi();

            }
            catch
            {
                MessageBox.Show("Đăng Ký thất bại!!");
                FDangkyphong_Load(sender, e);
            }

        }

        private void Txtmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadPhieu(string maphieu)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
             connect.Open();
            SqlCommand cmd = new SqlCommand("select * from DangKy where MaPhieuDky = '"+maphieu+"'",connect);
            SqlDataReader dr = cmd.ExecuteReader();
          //  SqlDataReader dr = con.LoadDuLieu("select * from DangKy where MaPhieuDky = '" + maphieu + "'");
            if(dr.Read())
            {
                txtmaphong.Text = dr[1].ToString();
                txttenkhach.Text = dr[2].ToString();
                txtsdt.Text = dr[3].ToString();
                date_dki.Text = dr[4].ToString();
                date_nhan.Text = dr[5].ToString();
                connect.Close();
            }
            else {
                MessageBox.Show("Phiếu không tồn tại");
                connect.Close();
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Modieukhien();
            btndangky.Enabled = false;
            btn_nhan.Enabled = true;
            LoadPhieu(txtmaphieu.Text);
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Setnull();
            Loadcombobox();
            Modieukhien();
            button2.Enabled = false;
        }

        private void Btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // Modieukhien();
                ec.Maphieu = txtmaphieu.Text;
                ec.Maphong = txtmaphong.Text;
                ec.Tenkhach = txttenkhach.Text;
                ec.SDT = txtsdt.Text;
                ec.Ngaydky = date_dki.Value.ToString("yyyy-MM-dd");
                ec.Ngaynhan = date_nhan.Value.ToString("yyyy-MM-dd");
                BUS.SuaDuLieu(ec);
                MessageBox.Show("Sửa thành công");
                FDangkyphong_Load(sender,e);
            }
            catch
            {
                MessageBox.Show("sửa thất bại!!!");
                FDangkyphong_Load(sender, e);
            }
        }

        private void Btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.Maphieu = txtmaphieu.Text;
                BUS.XoaduLieu(ec);
                MessageBox.Show("Xóa thành công");
                FDangkyphong_Load(sender, e);
            }
            catch {
                MessageBox.Show("Xóa Thất Bại!!");
                FDangkyphong_Load(sender, e);
            }
        }
        public delegate void delPassData(TextBox text);
        private void Btn_nhan_Click(object sender, EventArgs e)
        {
            FNhanphong f = new FNhanphong();
            this.Hide();
            delPassData del = new delPassData(f.FunData);
            del(this.txtmaphieu);
            f.ShowDialog();
            f.Show();
        }
    }
}
