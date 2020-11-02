namespace QuanLyKSan
{
    partial class FNhanphong
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
            this.txtmaphong = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtngaytra = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.danhsach = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtngaynhan = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Tra = new System.Windows.Forms.Button();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.Btn_search1 = new System.Windows.Forms.Button();
            this.BtnLuu = new System.Windows.Forms.Button();
            this.BtnXoa = new System.Windows.Forms.Button();
            this.BtnSua = new System.Windows.Forms.Button();
            this.BtnThem = new System.Windows.Forms.Button();
            this.txtmaphieudki = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaphieunhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txttenkhach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmaphong
            // 
            this.txtmaphong.Location = new System.Drawing.Point(156, 29);
            this.txtmaphong.Name = "txtmaphong";
            this.txtmaphong.Size = new System.Drawing.Size(100, 20);
            this.txtmaphong.TabIndex = 3;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(156, 144);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(190, 20);
            this.txtdiachi.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Địa chỉ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(156, 115);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(108, 20);
            this.txtSDT.TabIndex = 6;
            // 
            // txtngaytra
            // 
            this.txtngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaytra.Location = new System.Drawing.Point(156, 199);
            this.txtngaytra.Name = "txtngaytra";
            this.txtngaytra.Size = new System.Drawing.Size(108, 20);
            this.txtngaytra.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(800, 67);
            this.label11.TabIndex = 0;
            this.label11.Text = " Nhận Phòng";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.UseMnemonic = false;
            // 
            // danhsach
            // 
            this.danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhsach.Location = new System.Drawing.Point(2, 342);
            this.danhsach.Name = "danhsach";
            this.danhsach.Size = new System.Drawing.Size(771, 158);
            this.danhsach.TabIndex = 6;
            this.danhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DsNhanPhong_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "SDT";
            // 
            // txtngaynhan
            // 
            this.txtngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaynhan.Location = new System.Drawing.Point(156, 172);
            this.txtngaynhan.Name = "txtngaynhan";
            this.txtngaynhan.Size = new System.Drawing.Size(108, 20);
            this.txtngaynhan.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Tra);
            this.groupBox1.Controls.Add(this.btn_search2);
            this.groupBox1.Controls.Add(this.Btn_search1);
            this.groupBox1.Controls.Add(this.BtnLuu);
            this.groupBox1.Controls.Add(this.BtnXoa);
            this.groupBox1.Controls.Add(this.BtnSua);
            this.groupBox1.Controls.Add(this.BtnThem);
            this.groupBox1.Controls.Add(this.txtmaphieudki);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaphieunhan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 253);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhận phòng";
            // 
            // btn_Tra
            // 
            this.btn_Tra.Location = new System.Drawing.Point(294, 224);
            this.btn_Tra.Name = "btn_Tra";
            this.btn_Tra.Size = new System.Drawing.Size(75, 23);
            this.btn_Tra.TabIndex = 24;
            this.btn_Tra.Text = "Trả Phòng";
            this.btn_Tra.UseVisualStyleBackColor = true;
            this.btn_Tra.Click += new System.EventHandler(this.Btn_Tra_Click);
            // 
            // btn_search2
            // 
            this.btn_search2.Image = global::QuanLyKSan.Properties.Resources.find;
            this.btn_search2.Location = new System.Drawing.Point(266, 84);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(45, 31);
            this.btn_search2.TabIndex = 23;
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.Btn_search2_Click);
            // 
            // Btn_search1
            // 
            this.Btn_search1.Image = global::QuanLyKSan.Properties.Resources.find;
            this.Btn_search1.Location = new System.Drawing.Point(266, 47);
            this.Btn_search1.Name = "Btn_search1";
            this.Btn_search1.Size = new System.Drawing.Size(45, 31);
            this.Btn_search1.TabIndex = 22;
            this.Btn_search1.UseVisualStyleBackColor = true;
            this.Btn_search1.Click += new System.EventHandler(this.Btn_search1_Click);
            // 
            // BtnLuu
            // 
            this.BtnLuu.Location = new System.Drawing.Point(242, 176);
            this.BtnLuu.Name = "BtnLuu";
            this.BtnLuu.Size = new System.Drawing.Size(59, 23);
            this.BtnLuu.TabIndex = 21;
            this.BtnLuu.Text = "Lưu";
            this.BtnLuu.UseVisualStyleBackColor = true;
            this.BtnLuu.Click += new System.EventHandler(this.BtnLuu_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(177, 176);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(59, 23);
            this.BtnXoa.TabIndex = 20;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.UseVisualStyleBackColor = true;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Location = new System.Drawing.Point(112, 176);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(59, 23);
            this.BtnSua.TabIndex = 19;
            this.BtnSua.Text = "Sửa";
            this.BtnSua.UseVisualStyleBackColor = true;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.ForeColor = System.Drawing.Color.Black;
            this.BtnThem.Location = new System.Drawing.Point(47, 176);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(59, 23);
            this.BtnThem.TabIndex = 18;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.UseVisualStyleBackColor = true;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // txtmaphieudki
            // 
            this.txtmaphieudki.Location = new System.Drawing.Point(152, 88);
            this.txtmaphieudki.Name = "txtmaphieudki";
            this.txtmaphieudki.Size = new System.Drawing.Size(100, 20);
            this.txtmaphieudki.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phiếu đặt phòng";
            // 
            // txtmaphieunhan
            // 
            this.txtmaphieunhan.Location = new System.Drawing.Point(152, 51);
            this.txtmaphieunhan.Name = "txtmaphieunhan";
            this.txtmaphieunhan.Size = new System.Drawing.Size(100, 20);
            this.txtmaphieunhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu nhận";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtmaphong);
            this.groupBox2.Controls.Add(this.txtdiachi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtngaytra);
            this.groupBox2.Controls.Add(this.txtngaynhan);
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txttenkhach);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(383, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 253);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhận phòng";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(156, 90);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(108, 20);
            this.txtCMND.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày trả phòng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày nhận phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "CMND";
            // 
            // txttenkhach
            // 
            this.txttenkhach.Location = new System.Drawing.Point(156, 58);
            this.txttenkhach.Name = "txttenkhach";
            this.txttenkhach.Size = new System.Drawing.Size(148, 20);
            this.txttenkhach.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã phòng";
            // 
            // FNhanphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.danhsach);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FNhanphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNhanphong";
            this.Load += new System.EventHandler(this.FNhanphong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaphong;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker txtngaytra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView danhsach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtngaynhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnXoa;
        private System.Windows.Forms.Button BtnSua;
        private System.Windows.Forms.Button BtnThem;
        private System.Windows.Forms.TextBox txtmaphieudki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieunhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttenkhach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLuu;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.Button Btn_search1;
        private System.Windows.Forms.Button btn_Tra;
    }
}