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

namespace QuanLyKSan
{
    public partial class Fphong : Form
    {
        public BUS_Phong BUS = new BUS_Phong();
      
        public KetNoiDB con = new KetNoiDB();
        public EC_Phong ec = new EC_Phong();
     




        public Fphong()
        {
            InitializeComponent();        
            HienThi();
            KhoaDieuKhien();

        }
      

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = msds.CurrentRow.Index;
            txtMaPhong.Text = msds.Rows[i].Cells[0].Value.ToString();
            txtTenPhong.Text = msds.Rows[i].Cells[1].Value.ToString();
            txtLoaiPhong.Text = msds.Rows[i].Cells[2].Value.ToString();
             txtGia.Text = msds.Rows[i].Cells[3].Value.ToString();
            txtTinhtrang.Text = msds.Rows[i].Cells[4].Value.ToString();
            MoDieuKhien();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            txtMaPhong.Enabled = false;
            btnLuu.Enabled = false;



        }
        public void KhoaDieuKhien()
        {
            txtGia.Enabled = false;
            txtLoaiPhong.Enabled = false;
            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtTinhtrang.Enabled = false;

            btnLuu.Enabled = false;

            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtGia.Enabled = true;
            txtLoaiPhong.Enabled = true;
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtTinhtrang.Enabled = true;

            btnLuu.Enabled = true;

            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }
        void HienThi()
        {
            con.MoKetNoi();
            msds.DataSource = BUS.TaoBang("SELECT * FROM Phong1");
            con.DongKetNoi();

        }
        void SetNull()
        {
            txtGia.Text = "";
            txtLoaiPhong.Text = "";
            txtMaPhong.Text = "";
            txtTenPhong.Text = "";
            txtTinhtrang.Text = "";
          

        }
      

        private void Form1_Load(object sender, EventArgs e)
        {

            KhoaDieuKhien();  
            HienThi();
            SetNull();

        }
       
        private void BtnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            SetNull();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
              try
               {
                   ec.Maphong = txtMaPhong.Text;
                   ec.Tenphong = txtTenPhong.Text;
                   ec.Loaiphong = txtLoaiPhong.Text;
                    ec.Gia = float.Parse(txtGia.Text);
                    ec.Tinhtrang = txtTinhtrang.Text;
                 //ec.Status = "0";
                   BUS.ThemDuLieu(ec);
                    SetNull();
                    KhoaDieuKhien();
                   HienThi();
                 MessageBox.Show("Thêm thành công");

               }
            catch { MessageBox.Show("Thêm thất bại"); }
         

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa phòng", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                ec.Maphong = txtMaPhong.Text;
                BUS.XoaduLieu(ec);
                if (BUS.XoaduLieu(ec) != -1)
                    MessageBox.Show("xóa thành công");
                else 
                    MessageBox.Show("Dữ liệu đang được dùng ở bảng khác! Không thể xóa");
                Form1_Load(sender, e);
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            ec.Maphong = txtMaPhong.Text;
            ec.Tenphong = txtTenPhong.Text;
            ec.Loaiphong = txtLoaiPhong.Text;
            ec.Gia = float.Parse(txtGia.Text);
            ec.Tinhtrang = txtTinhtrang.Text;           
            BUS.SuaDuLieu(ec);
            MessageBox.Show("Đã sửa");
            Form1_Load(sender, e);

        }
    }
}
