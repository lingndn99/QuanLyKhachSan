using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSanBUS;
using QuanLyKhachSanDAL;
using QuanLyKhachSanEmtyti;

namespace QuanLyKSan
{
    public partial class FHome : Form
    {
        public BUS_Phong BUS = new BUS_Phong();

        public KetNoiDB con = new KetNoiDB();
        public EC_Phong ec = new EC_Phong();

        public FHome()
        {
            InitializeComponent();
            LoadListView();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            FDangkyphong f = new FDangkyphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

       

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Fphong f = new Fphong();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void Label44_Click(object sender, EventArgs e)
        {

        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            FNhanphong f = new FNhanphong();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            FTraphong f = new FTraphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
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
            //  connect = new SqlConnection(@"Data Source=DESKTOP-86M3SB6\SQLEXPRESS;Initial Catalog=QuanLyKhachSan;Integrated Security=True");
            //  connect.Open();
            //  DataTable dt = new DataTable();
            //  SqlDataAdapter data = new SqlDataAdapter("select MaPhong,TinhTrang from Phong1", connect);

            //  data.Fill(dt);
            con.MoKetNoi();
            DataTable dt = con.LayDuLieuBang("select MaPhong, TinhTrang,status from Phong1");
            //do du lieu vao list view
            DSP.Items.Clear();
            DSP.View = View.LargeIcon;
            DSP.Columns.Add("ten phong");
            DSP.Columns.Add("tinhtrang");
            DSP.Columns.Add("status");
            LoadIMG();
            DSP.LargeImageList = img;

            int i = 0;
            foreach(DataRow row in dt.Rows)
            {
                DSP.Items.Add(row["MaPhong"].ToString());
                DSP.Items[i].SubItems.Add( row["TinhTrang"].ToString() );
                DSP.Items[i].SubItems.Add(row["status"].ToString());
              
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
        public delegate void delPassData(string text);
        
       
        private void DSP_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (DSP.SelectedItems.Count > 0)
            {
              //  foreach (ListViewItem item in DSP.SelectedItems)
               // {
               //     MessageBox.Show(item.Text);
               // }
                ListViewItem item1 = DSP.SelectedItems[0];
               // ListViewItem item2 = DSP.SelectedItems[0];
                
               // MessageBox.Show(item1.SubItems.text);
                if(item1.ImageIndex ==  0 )
                {
                   
                   DialogResult dr= MessageBox.Show("Bạn muốn đặt phòng","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        FDangkyphong f = new FDangkyphong();

                        delPassData del = new delPassData(f.FunData1);
                       // MessageBox.Show(item1.Text);
                         del(item1.Text);
                        f.Show();
                        item1.ImageIndex = 1;
                    }

                }
                else if(item1.ImageIndex == 1)
                {
                    DialogResult dr = MessageBox.Show("Bạn muốn nhận phòng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                       // MessageBox.Show(item1.SubItems[2].Text);
                        FNhanphong f = new FNhanphong();
                        delPassData del = new delPassData(f.FunData2);
                        del(item1.SubItems[2].Text);
                        f.Show();
                        item1.ImageIndex = 2;
                    }
                }
                else if(item1.ImageIndex == 2)
                {
                    DialogResult dr = MessageBox.Show("Bạn muốn trả phòng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        FTraphong f = new FTraphong();
                        delPassData del = new delPassData(f.FunData2);
                        del(item1.SubItems[2].Text);
                        f.Show();
                        item1.ImageIndex = 0;
                    }
                }
                   
                
                
            }
        }
        public static SqlConnection connect;
        private void FHome_Load(object sender, EventArgs e)
        {
            

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FTimphong f = new FTimphong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                Application.Exit();
            }
           
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn Đăng xuất!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                FDangNhap f = new FDangNhap();
                f.Show();
                this.Hide();
            }
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FReport f = new FReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FNhanVien f = new FNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void KhachHang_Click(object sender, EventArgs e)
        {
            FKhachHang f = new FKhachHang();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
