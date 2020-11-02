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

namespace QuanLyKSan
{
    public partial class FNhanVien : Form
    {
        public BUS_NhanVien BUS = new BUS_NhanVien();
        public EC_NhanVien ec = new EC_NhanVien();
        public KetNoiDB con = new KetNoiDB();
        public FNhanVien()
        {
            InitializeComponent();
            KhoaDieuKhien();
            HienThi();
        }
        public void KhoaDieuKhien()
        {
            txtmanv.Enabled = false;
            txttennv.Enabled = false;
            txtsdt.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            txtdiachi.Enabled = false;
            txtngaysinh.Enabled = false;

            BtnLuu.Enabled = false;

            BtnSua.Enabled = false;
            BtnThem.Enabled = true;
            BtnXoa.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtmanv.Enabled = true;
            txttennv.Enabled = true;
            txtsdt.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            txtdiachi.Enabled = true;
            txtngaysinh.Enabled = true;

            BtnLuu.Enabled = true;

            BtnSua.Enabled = true;
            BtnThem.Enabled = false;
            BtnXoa.Enabled = true;
        }
        void HienThi()
        {
            con.MoKetNoi();
            dsnv.DataSource = BUS.TaoBang("SELECT * FROM NhanVien");
            con.DongKetNoi();
        }
        void SetNull()
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdiachi.Text = "";
        }

        private void dsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dsnv.CurrentRow.Index;
            txtmanv.Text = dsnv.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = dsnv.Rows[i].Cells[1].Value.ToString();
            txtngaysinh.Text = dsnv.Rows[i].Cells[2].Value.ToString();
            txtsdt.Text = dsnv.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dsnv.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = dsnv.Rows[i].Cells[5].Value.ToString();

            MoDieuKhien();
            BtnLuu.Enabled = false;
            BtnThem.Enabled = true;
        }

        private void FNhanVien_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            HienThi();
            SetNull();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            BtnSua.Enabled = false;
            BtnXoa.Enabled = false;
            SetNull();
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                ec.MaNhanVien = txtmanv.Text;
                ec.TenNhanVien = txttennv.Text;
                ec.SDT = txtsdt.Text;
                ec.Email = txtemail.Text;
                ec.DiaChi = txtdiachi.Text;
                ec.NgaySinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
                BUS.ThemDuLieu(ec);
                FNhanVien_Load(sender, e);
                MessageBox.Show("Thêm thành công");

            }
            catch { MessageBox.Show("Thêm thất bại"); }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            ec.MaNhanVien = txtmanv.Text;
            ec.TenNhanVien = txttennv.Text;
            ec.SDT = txtsdt.Text;
            ec.Email = txtemail.Text;
            ec.DiaChi = txtdiachi.Text;
            ec.NgaySinh = txtngaysinh.Value.ToString("yyyy-MM-dd");
            BUS.SuaDuLieu(ec);
            MessageBox.Show("Đã sửa");
            FNhanVien_Load(sender, e);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin nhân viên", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                ec.MaNhanVien = txtmanv.Text;
                BUS.XoaduLieu(ec);
                if (BUS.XoaduLieu(ec) != -1)
                    MessageBox.Show("xóa thành công");
                else
                    MessageBox.Show("Dữ liệu đang được dùng ở bảng khác! Không thể xóa");
                FNhanVien_Load(sender, e);
            }
        }
    }
}
