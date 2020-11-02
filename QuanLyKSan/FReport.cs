using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKSan
{
    public partial class FReport : Form
    {
        public FReport()
        {
            InitializeComponent();
        }

        private void FReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyKhachSanDataSet2.BCDoanhThu' table. You can move, or remove it, as needed.
          

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.BCKhachHangTheoNgayTableAdapter.Fill(this.QuanLyKhachSanDataSet1.BCKhachHangTheoNgay, txtTuNgay.Value, txtDenNgay.Value);
            this.reportViewer1.RefreshReport();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int thang = int.Parse ( CBThang.Text);
            this.BCDoanhThuTableAdapter.Fill(this.QuanLyKhachSanDataSet2.BCDoanhThu,dateTungay.Value,dateDenNgay.Value,thang);
            this.reportViewer2.RefreshReport();
        }
    }
}
