using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanBUS;
using QuanLyKhachSanDAL;
using QuanLyKhachSanEmtyti;
using System.Data.SqlClient;

namespace QuanLyKSan
{
    public partial class FDangNhap : Form
    {
        public KetNoiDB con = new KetNoiDB();
        public FDangNhap()
        {
            InitializeComponent();
        }
        
        private string GetID(string username, string pass)
        {
            string id = "";
            try
            {
                con.MoKetNoi();
                // SqlCommand cmd = new SqlCommand("SELECT * FROM TaiKhoan WHERE TenDangNhap ='" + username + "' and MatKhau='" + pass + "'", connect);
                //  SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = con.LayDuLieuBang("SELECT * FROM TaiKhoan WHERE TenDangNhap ='" + username + "' and MatKhau='" + pass + "'");
              
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        id = dr["id"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.DongKetNoi();
            }
            return id;
        }
        public static string id_user;
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            id_user = GetID(txtTDN.Text, txtMK.Text);
            if (id_user != "")
            {
                FHome f = new FHome();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoảng hoặc mật khẩu không đúng !");
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
