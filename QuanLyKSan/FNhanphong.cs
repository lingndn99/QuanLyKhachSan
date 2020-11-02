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

namespace QuanLyKSan
{
    public partial class FNhanphong : Form
    {
        readonly BUS_NhanPhong BUS = new BUS_NhanPhong();
        readonly EC_NhanPhong ec = new EC_NhanPhong();
        readonly EC_Phong ec_phong = new EC_Phong();
        readonly BUS_Phong Phong = new BUS_Phong();
        readonly KetNoiDB con = new KetNoiDB();


        public FNhanphong()
        {
            InitializeComponent();
            con.MoKetNoi();
            HienThiDS();
           con.DongKetNoi();
            Khoadieukhien();
        }
        public void FunData2(string txthome)
        {
            Modieukhien();
            txtmaphieudki.Text = txthome;
            LoadPhieudki(txtmaphieudki.Text);
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            btn_Tra.Enabled = false;
        }

        public void FunData(TextBox txtFdky)
        {
            Modieukhien();
            txtmaphieudki.Text = txtFdky.Text;
            LoadPhieudki(txtmaphieudki.Text);
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            btn_Tra.Enabled = false;
        }
        public void Khoadieukhien()
        {
            txtmaphieunhan.Enabled = true;
            txtmaphieudki.Enabled = true;
            txtmaphong.Enabled = false;
            txttenkhach.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            txtdiachi.Enabled = false;
            txtngaynhan.Enabled = false;
            txtngaytra.Enabled = false;

            BtnThem.Enabled = true;
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            BtnLuu.Enabled = false;
        }
        public void Modieukhien()
        {
            txtmaphieunhan.Enabled = true;
            txtmaphieudki.Enabled = true;
            txtmaphong.Enabled = true;
            txttenkhach.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;
            txtdiachi.Enabled = true;
            txtngaynhan.Enabled = true;
            txtngaytra.Enabled = true;

            BtnThem.Enabled = false;
            BtnSua.Enabled = true;
            BtnXoa.Enabled = true;
            BtnLuu.Enabled = true;
        }
        public void SetNull()
        {
            txtmaphieunhan.Text = "";
            txtmaphieudki.Text ="" ;
            txtmaphong.Text ="";
            txttenkhach.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtdiachi.Text = "";
            txtngaynhan.Text = "";
            txtngaytra.Text = "";

        }
        void NhanPhong()
        {
            string a = "da nhan";
            try
            {
                ec_phong.Maphong = txtmaphong.Text;
                ec_phong.Tinhtrang = a.ToString();
                ec_phong.Status = txtmaphieunhan.Text;
                Phong.DangKy(ec_phong);
               // MessageBox.Show("nhan phong");
            }
            catch { MessageBox.Show("Lỗi Nhận Phòng"); }
        }
        void HienThiDS()
        {
            danhsach.DataSource = BUS.TaoBang("select * from NhanPhong1");
               
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            Modieukhien();
            SetNull();
        }

        private void DsNhanPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = danhsach.CurrentRow.Index;
            txtmaphieunhan.Text = danhsach.Rows[i].Cells[0].Value.ToString();
            txtmaphieudki.Text = danhsach.Rows[i].Cells[1].Value.ToString();
            txtmaphong.Text = danhsach.Rows[i].Cells[2].Value.ToString();
            txttenkhach.Text = danhsach.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = danhsach.Rows[i].Cells[4].Value.ToString();
            txtCMND.Text = danhsach.Rows[i].Cells[5].Value.ToString();
            txtdiachi.Text = danhsach.Rows[i].Cells[6].Value.ToString();
            txtngaynhan.Text = danhsach.Rows[i].Cells[7].Value.ToString();
            txtngaytra.Text = danhsach.Rows[i].Cells[8].Value.ToString();
            Modieukhien();
            BtnLuu.Enabled = false;
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Modieukhien();
                ec.MaPhieu =  txtmaphieunhan.Text;
                ec.MaDky = txtmaphieudki.Text;
                ec.MaPhong = txtmaphong.Text;
                ec.TenKhach = txttenkhach.Text;
                ec.SDT = txtSDT.Text;
                ec.CMND = txtCMND.Text;
                ec.DiaChi = txtdiachi.Text;
                ec.NgayNhan = txtngaynhan.Value.ToString("yyyy-MM-dd");
                ec.NgayTra = txtngaytra.Value.ToString("yyyy-MM-dd");
                 BUS.ThemDuLieu(ec);
                SetNull();
                //connect = new SqlConnection(@"Data Source=DESKTOP86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
                //  connect.Open();
                //  SqlCommand cmd = new SqlCommand("INSERT INTO NhanPhong1 (MaPhieuDKy, MaPhieuNhan, MaPhong, TenKhach, SDT, CMND, DiaChi, NgayNhan, NgayTra)VALUES(N'" + ec.MaPhieu + "', N'" + ec.MaDky + "', N'" + ec.MaPhong + "', N'" + ec.TenKhach + "', N'" + ec.SDT + "', N'" + ec.CMND + "', N'" + ec.DiaChi + "', '" + ec.NgayNhan + "', '" + ec.NgayTra + "') ", connect);
                //   cmd.ExecuteNonQuery();
                // connect.Close();
                MessageBox.Show(" Nhận phòng thành công ");
                NhanPhong();
                HienThiDS();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //MessageBox.Show("loi"); 
            }
        }

            private void FNhanphong_Load(object sender, EventArgs e)
        {
            HienThiDS();
        }
        //sua du lieu
        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaPhieu = txtmaphieunhan.Text;
                ec.MaDky = txtmaphieudki.Text;
                ec.MaPhong = txtmaphong.Text;
                ec.TenKhach = txttenkhach.Text;
                ec.SDT = txtSDT.Text;
                ec.CMND = txtCMND.Text;
                ec.DiaChi = txtdiachi.Text;
                ec.NgayNhan = txtngaynhan.Value.ToString("yyyy-MM-dd");
                ec.NgayTra = txtngaytra.Value.ToString("yyyy-MM-dd");
                BUS.SuaDuLieu(ec);
                MessageBox.Show("Sửa thành công");
                HienThiDS();
            }
            catch
            {
                MessageBox.Show("Sửa thất bại");
            }

        }
        //xoa du lieu
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaPhieu = txtmaphieunhan.Text;
               
                BUS.XoaduLieu(ec);
                MessageBox.Show("xóa thành công");
                HienThiDS();
            }
            catch
            {
                MessageBox.Show("xóa thất bại");
            }
        }
        //lay du lieu tu phieu dky
        public static SqlConnection connect;
        public void LoadPhieudki(string maphieu)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from DangKy where MaPhieuDky = '" + maphieu + "'", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtmaphong.Text = dr[1].ToString();
                txttenkhach.Text = dr[2].ToString();
                txtSDT.Text = dr[3].ToString();
               // txtngaynhan.Text = dr[4].ToString();
                txtngaynhan.Text = dr[5].ToString();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Phiếu không tồn tại");
                connect.Close();
            }

        }
        // load phieu nhan
        public void LoadPhieuNhan(string maphieu)
        {
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from NhanPhong1 where MaPhieuNhan = '" + maphieu + "'", connect);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtmaphieunhan.Text = dr[0].ToString();
                txtmaphieudki.Text = dr[1].ToString();
                txtmaphong.Text = dr[2].ToString();
                txttenkhach.Text = dr[3].ToString();
                txtSDT.Text = dr[4].ToString();
                txtCMND.Text = dr[5].ToString();
                txtdiachi.Text= dr[6].ToString();
                 txtngaynhan.Text = dr[7].ToString();
                txtngaytra.Text = dr[8].ToString();
                connect.Close();
            }
            else
            {
                MessageBox.Show("Phiếu không tồn tại");
                connect.Close();
            }

        }

        private void Btn_search1_Click(object sender, EventArgs e)
        {
            LoadPhieuNhan(txtmaphieunhan.Text);
            Modieukhien();
            BtnLuu.Enabled = false;
            BtnThem.Enabled = true;
        }
        //tim theo phieu dki
        private void Btn_search2_Click(object sender, EventArgs e)
        {
            LoadPhieudki(txtmaphieudki.Text);
            Modieukhien();
            BtnLuu.Enabled = true;
        }

        //chuyen du lieu qua form tra phong
        public delegate void delPassData(TextBox text);
       private void Btn_Tra_Click(object sender, EventArgs e)
        {
           FTraphong f = new FTraphong();
           delPassData del = new delPassData(f.FunData);
          del(this.txtmaphieunhan);
           f.Show();
        }
    }
}
