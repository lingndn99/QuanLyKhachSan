using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhachSanDAL;

namespace QuanLyKSan
{
    public partial class FTimphong : Form
    {
        public FTimphong()
        {
            InitializeComponent();
          
        }
        public static SqlConnection connect;
        readonly KetNoiDB con = new KetNoiDB();
        ImageList img;
        void LoadIMG()
        {
            img = new ImageList() { ImageSize = new Size(64, 64) };
            img.Images.Add(new Bitmap(Application.StartupPath + "\\image\\trong.jpg"));
            img.Images.Add(new Bitmap(Application.StartupPath + "\\image\\dat.jpg"));
            img.Images.Add(new Bitmap(Application.StartupPath + "\\image\\khach.jpg"));
        }
        void LoadListView()
        {
            //lay du lieu phong
            connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            connect.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter("select MaPhong,TinhTrang from Phong1 where MaPhong LIKE'"+tang.Text+"%' and LoaiPhong LIKE'"+loaiphong.Text+"' and Gia <= '"+ gia.Text + "' ", connect);

            data.Fill(dt);
            //do du lieu vao list view
            DSP.Items.Clear();
            DSP.View = View.LargeIcon;
            DSP.Columns.Add("ten phong");
            DSP.Columns.Add("tinhtrang");
            LoadIMG();
            DSP.LargeImageList = img;

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                DSP.Items.Add(row["MaPhong"].ToString());
                DSP.Items[i].SubItems.Add(row["TinhTrang"].ToString());

                if (DSP.Items[i].SubItems[1].Text == "trong")
                {
                    DSP.Items[i].ImageIndex = 0;
                }
                else if (DSP.Items[i].SubItems[1].Text == "da dat")
                {
                    DSP.Items[i].ImageIndex = 1;
                }
                else { DSP.Items[i].ImageIndex = 2; }
                i++;
            }

        }
        void LoadPhongTrong()
        {
            // connect = new SqlConnection(@"Data Source=DESKTOP-KMNS09Q\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            //connect.Open();
            // DataTable dt = connect.;
            // SqlDataAdapter data = new SqlDataAdapter("select MaPhong,TinhTrang from Phong1 where  MaPhong LIKE'" + tang.Text + "%' and TinhTrang ='trong' and LoaiPhong LIKE'" + loaiphong.Text + "' and Gia <= '" + gia.Text + "' ", connect);
            //data.Fill(dt);
            con.MoKetNoi();
            DataTable dt = con.LayDuLieuBang("select MaPhong, TinhTrang from Phong1 where MaPhong LIKE'" + tang.Text + "%' and TinhTrang = 'trong' and LoaiPhong LIKE'" + loaiphong.Text + "' and Gia <= '" + gia.Text + "' ");

            Phong.Items.Clear();
            Phong.View = View.Details;
            Phong.FullRowSelect = true;
            Phong.GridLines = true;
            Phong.CheckBoxes = true; 
             Phong.Columns.Add("ten phong");
            Phong.Columns.Add("tinhtrang");
         //   Phong.Columns.Add("Dat Phong");

            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                Phong.Items.Add(row["MaPhong"].ToString());
                Phong.Items[i].SubItems.Add(row["TinhTrang"].ToString());
                i++;
            }


        }

        private void FTimphong_Load(object sender, EventArgs e)
        {
            LoadListView();
            LoadPhongTrong();
        }

        private void BtnTimkiem_Click(object sender, EventArgs e)
        {
            FTimphong_Load(sender, e);
        }
        public delegate void delPassData(string text);
        private void Phong_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DSP.SelectedItems.Count > 0)
            {
                ListViewItem item1 = DSP.SelectedItems[0];
                foreach (ListViewItem item in Phong.SelectedItems)
                {
                    if (item.Checked)
                    {
                        DialogResult dr = MessageBox.Show("Bạn muốn đặt phòng", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (dr == DialogResult.OK)
                        {
                            FDangkyphong f = new FDangkyphong();
                            delPassData del = new delPassData(f.FunData1);
                            del(item1.Text);
                            f.Show();
                           
                        }
                    }
                }
            }
        }

        private void BtnDky_Click(object sender, EventArgs e)
        {
            Phong_SelectedIndexChanged(sender, e);
        }
    }
}
