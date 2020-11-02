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
    public partial class FKhachHang : Form
    {
        public BUS_KhachHang BUS = new BUS_KhachHang();
        public EC_KhachHang ec = new EC_KhachHang();
        public KetNoiDB con = new KetNoiDB();
        public FKhachHang()
        {
            InitializeComponent();
            KhoaDieuKhien();
            HienThi();
        }
        public void KhoaDieuKhien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = false;
            txtsdt.Enabled = false;
            txtcmnd.Enabled = false;
            txtdiachi.Enabled = false;

            BtnLuu.Enabled = false;

            BtnSua.Enabled = false;
            BtnThem.Enabled = true;
            BtnXoa.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtmakh.Enabled = false;
            txttenkh.Enabled = true;
            txtsdt.Enabled = true;
            txtcmnd.Enabled = true;
            txtdiachi.Enabled = true;

            BtnLuu.Enabled = true;

            BtnSua.Enabled = true;
            BtnThem.Enabled = false;
            BtnXoa.Enabled = true;
        }
        void HienThi()
        {
            con.MoKetNoi();
            dskh.DataSource = BUS.TaoBang("SELECT * FROM KhachHang");
            con.DongKetNoi();

        }
        void SetNull()
        {
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtsdt.Text = "";
            txtcmnd.Text = "";
            txtdiachi.Text = "";


        }

        private void dskh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dskh.CurrentRow.Index;
            txtmakh.Text = dskh.Rows[i].Cells[0].Value.ToString();
            txttenkh.Text = dskh.Rows[i].Cells[1].Value.ToString();
            txtsdt.Text = dskh.Rows[i].Cells[2].Value.ToString();
            txtcmnd.Text = dskh.Rows[i].Cells[3].Value.ToString();
            txtdiachi.Text = dskh.Rows[i].Cells[4].Value.ToString();

            MoDieuKhien();
            BtnLuu.Enabled = false;
            BtnThem.Enabled = true;

        }

        private void FKhachHang_Load(object sender, EventArgs e)
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
                ec.MaKhachHang = txtmakh.Text;
                ec.TenKhach = txttenkh.Text;
                ec.SDT = txtsdt.Text;
                ec.CMND = txtcmnd.Text;
                ec.DiaChi = txtdiachi.Text;
                BUS.ThemDuLieu(ec);
                FKhachHang_Load(sender, e);
                MessageBox.Show("Thêm thành công");

            }
            catch { MessageBox.Show("Thêm thất bại"); }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            
            ec.MaKhachHang = txtmakh.Text;
            ec.TenKhach = txttenkh.Text;
            ec.SDT = txtsdt.Text;
            ec.CMND = txtcmnd.Text;
            ec.DiaChi = txtdiachi.Text;
            BUS.SuaDuLieu(ec);
            MessageBox.Show("Đã sửa");
            FKhachHang_Load(sender, e);
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn xóa thông tin khách hàng", "Cảnh Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                ec.MaKhachHang = txtmakh.Text;
                BUS.XoaduLieu(ec);
                if (BUS.XoaduLieu(ec) != -1)
                    MessageBox.Show("xóa thành công");
                else
                    MessageBox.Show("Dữ liệu đang được dùng ở bảng khác! Không thể xóa");
                FKhachHang_Load(sender, e);
            }
        }
    }
}
