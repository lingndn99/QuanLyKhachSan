namespace QuanLyKSan
{
    partial class FReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnThongKe = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DoanhSo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBThang = new System.Windows.Forms.ComboBox();
            this.dateDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTungay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.QuanLyKhachSanDataSet1 = new QuanLyKSan.QuanLyKhachSanDataSet1();
            this.BCKhachHangTheoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BCKhachHangTheoNgayTableAdapter = new QuanLyKSan.QuanLyKhachSanDataSet1TableAdapters.BCKhachHangTheoNgayTableAdapter();
            this.QuanLyKhachSanDataSet2 = new QuanLyKSan.QuanLyKhachSanDataSet2();
            this.BCDoanhThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BCDoanhThuTableAdapter = new QuanLyKSan.QuanLyKhachSanDataSet2TableAdapters.BCDoanhThuTableAdapter();
            this.BtnThongKe.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DoanhSo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCKhachHangTheoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCDoanhThuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BCKhachHangTheoNgayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKSan.Thongkekhach.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 20);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1058, 407);
            this.reportViewer1.TabIndex = 0;
            // 
            // BtnThongKe
            // 
            this.BtnThongKe.Controls.Add(this.button1);
            this.BtnThongKe.Controls.Add(this.label2);
            this.BtnThongKe.Controls.Add(this.label1);
            this.BtnThongKe.Controls.Add(this.txtDenNgay);
            this.BtnThongKe.Controls.Add(this.txtTuNgay);
            this.BtnThongKe.Location = new System.Drawing.Point(0, 7);
            this.BtnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.BtnThongKe.Name = "BtnThongKe";
            this.BtnThongKe.Padding = new System.Windows.Forms.Padding(4);
            this.BtnThongKe.Size = new System.Drawing.Size(1067, 74);
            this.BtnThongKe.TabIndex = 1;
            this.BtnThongKe.TabStop = false;
            this.BtnThongKe.Text = "Thống kê khách theo ngày";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(736, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ Ngày";
            // 
            // txtDenNgay
            // 
            this.txtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDenNgay.Location = new System.Drawing.Point(485, 34);
            this.txtDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDenNgay.Name = "txtDenNgay";
            this.txtDenNgay.Size = new System.Drawing.Size(149, 22);
            this.txtDenNgay.TabIndex = 1;
            // 
            // txtTuNgay
            // 
            this.txtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtTuNgay.Location = new System.Drawing.Point(167, 34);
            this.txtTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuNgay.Name = "txtTuNgay";
            this.txtTuNgay.Size = new System.Drawing.Size(149, 22);
            this.txtTuNgay.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.Location = new System.Drawing.Point(8, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1067, 431);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // DoanhSo
            // 
            this.DoanhSo.Controls.Add(this.tabPage1);
            this.DoanhSo.Controls.Add(this.tabPage2);
            this.DoanhSo.Location = new System.Drawing.Point(1, 4);
            this.DoanhSo.Margin = new System.Windows.Forms.Padding(4);
            this.DoanhSo.Name = "DoanhSo";
            this.DoanhSo.SelectedIndex = 0;
            this.DoanhSo.Size = new System.Drawing.Size(1136, 566);
            this.DoanhSo.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnThongKe);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1128, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Doanh Số";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1128, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Doanh thu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.reportViewer2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(4, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1120, 406);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.BCDoanhThuBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyKSan.DoanhThu.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 19);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1112, 383);
            this.reportViewer2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBThang);
            this.groupBox1.Controls.Add(this.dateDenNgay);
            this.groupBox1.Controls.Add(this.dateTungay);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1120, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê theo ngày - tháng";
            // 
            // CBThang
            // 
            this.CBThang.FormattingEnabled = true;
            this.CBThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.CBThang.Location = new System.Drawing.Point(256, 84);
            this.CBThang.Margin = new System.Windows.Forms.Padding(4);
            this.CBThang.Name = "CBThang";
            this.CBThang.Size = new System.Drawing.Size(100, 24);
            this.CBThang.TabIndex = 6;
            this.CBThang.Text = "5";
            // 
            // dateDenNgay
            // 
            this.dateDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDenNgay.Location = new System.Drawing.Point(597, 38);
            this.dateDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateDenNgay.Name = "dateDenNgay";
            this.dateDenNgay.Size = new System.Drawing.Size(156, 22);
            this.dateDenNgay.TabIndex = 5;
            // 
            // dateTungay
            // 
            this.dateTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTungay.Location = new System.Drawing.Point(193, 36);
            this.dateTungay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTungay.Name = "dateTungay";
            this.dateTungay.Size = new System.Drawing.Size(148, 22);
            this.dateTungay.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Đến Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ Ngày";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 87);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Thống kê";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // QuanLyKhachSanDataSet1
            // 
            this.QuanLyKhachSanDataSet1.DataSetName = "QuanLyKhachSanDataSet1";
            this.QuanLyKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BCKhachHangTheoNgayBindingSource
            // 
            this.BCKhachHangTheoNgayBindingSource.DataMember = "BCKhachHangTheoNgay";
            this.BCKhachHangTheoNgayBindingSource.DataSource = this.QuanLyKhachSanDataSet1;
            // 
            // BCKhachHangTheoNgayTableAdapter
            // 
            this.BCKhachHangTheoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // QuanLyKhachSanDataSet2
            // 
            this.QuanLyKhachSanDataSet2.DataSetName = "QuanLyKhachSanDataSet2";
            this.QuanLyKhachSanDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BCDoanhThuBindingSource
            // 
            this.BCDoanhThuBindingSource.DataMember = "BCDoanhThu";
            this.BCDoanhThuBindingSource.DataSource = this.QuanLyKhachSanDataSet2;
            // 
            // BCDoanhThuTableAdapter
            // 
            this.BCDoanhThuTableAdapter.ClearBeforeFill = true;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 554);
            this.Controls.Add(this.DoanhSo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FReport";
            this.Text = "FReport";
            this.Load += new System.EventHandler(this.FReport_Load);
            this.BtnThongKe.ResumeLayout(false);
            this.BtnThongKe.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.DoanhSo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCKhachHangTheoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyKhachSanDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BCDoanhThuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox BtnThongKe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtDenNgay;
        private System.Windows.Forms.DateTimePicker txtTuNgay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl DoanhSo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBThang;
        private System.Windows.Forms.DateTimePicker dateDenNgay;
        private System.Windows.Forms.DateTimePicker dateTungay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource BCKhachHangTheoNgayBindingSource;
        private QuanLyKhachSanDataSet1 QuanLyKhachSanDataSet1;
        private QuanLyKhachSanDataSet1TableAdapters.BCKhachHangTheoNgayTableAdapter BCKhachHangTheoNgayTableAdapter;
        private System.Windows.Forms.BindingSource BCDoanhThuBindingSource;
        private QuanLyKhachSanDataSet2 QuanLyKhachSanDataSet2;
        private QuanLyKhachSanDataSet2TableAdapters.BCDoanhThuTableAdapter BCDoanhThuTableAdapter;
    }
}