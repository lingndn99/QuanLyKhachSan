namespace QuanLyKSan
{
    partial class FTimphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTimphong));
            this.tang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnTimkiem = new System.Windows.Forms.Button();
            this.gia = new System.Windows.Forms.ComboBox();
            this.loaiphong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DSP = new System.Windows.Forms.ListView();
            this.Phong = new System.Windows.Forms.ListView();
            this.BtnDky = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tang
            // 
            this.tang.FormattingEnabled = true;
            this.tang.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.tang.Location = new System.Drawing.Point(105, 21);
            this.tang.Name = "tang";
            this.tang.Size = new System.Drawing.Size(139, 21);
            this.tang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá phòng";
            // 
            // BtnTimkiem
            // 
            this.BtnTimkiem.Location = new System.Drawing.Point(274, 136);
            this.BtnTimkiem.Name = "BtnTimkiem";
            this.BtnTimkiem.Size = new System.Drawing.Size(85, 30);
            this.BtnTimkiem.TabIndex = 8;
            this.BtnTimkiem.Text = "Tìm kiếm";
            this.BtnTimkiem.UseVisualStyleBackColor = true;
            this.BtnTimkiem.Click += new System.EventHandler(this.BtnTimkiem_Click);
            // 
            // gia
            // 
            this.gia.FormattingEnabled = true;
            this.gia.Items.AddRange(new object[] {
            "1000000",
            "500000",
            "200000",
            "100000"});
            this.gia.Location = new System.Drawing.Point(105, 100);
            this.gia.Name = "gia";
            this.gia.Size = new System.Drawing.Size(139, 21);
            this.gia.TabIndex = 7;
            // 
            // loaiphong
            // 
            this.loaiphong.FormattingEnabled = true;
            this.loaiphong.Items.AddRange(new object[] {
            "vip",
            "don",
            "doi"});
            this.loaiphong.Location = new System.Drawing.Point(105, 58);
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.Size = new System.Drawing.Size(139, 21);
            this.loaiphong.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnTimkiem);
            this.groupBox1.Controls.Add(this.gia);
            this.groupBox1.Controls.Add(this.loaiphong);
            this.groupBox1.Controls.Add(this.tang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 168);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vị trí tầng";
            // 
            // DSP
            // 
            this.DSP.HideSelection = false;
            this.DSP.Location = new System.Drawing.Point(38, 191);
            this.DSP.Name = "DSP";
            this.DSP.Size = new System.Drawing.Size(724, 183);
            this.DSP.TabIndex = 8;
            this.DSP.UseCompatibleStateImageBehavior = false;
            // 
            // Phong
            // 
            this.Phong.HideSelection = false;
            this.Phong.Location = new System.Drawing.Point(487, 17);
            this.Phong.Name = "Phong";
            this.Phong.Size = new System.Drawing.Size(190, 168);
            this.Phong.TabIndex = 9;
            this.Phong.UseCompatibleStateImageBehavior = false;
            this.Phong.SelectedIndexChanged += new System.EventHandler(this.Phong_SelectedIndexChanged);
            // 
            // BtnDky
            // 
            this.BtnDky.BackColor = System.Drawing.Color.Chocolate;
            this.BtnDky.ForeColor = System.Drawing.Color.Red;
            this.BtnDky.Image = ((System.Drawing.Image)(resources.GetObject("BtnDky.Image")));
            this.BtnDky.Location = new System.Drawing.Point(696, 146);
            this.BtnDky.Name = "BtnDky";
            this.BtnDky.Size = new System.Drawing.Size(66, 37);
            this.BtnDky.TabIndex = 10;
            this.BtnDky.Text = "Đăng ký";
            this.BtnDky.UseVisualStyleBackColor = false;
            this.BtnDky.Click += new System.EventHandler(this.BtnDky_Click);
            // 
            // FTimphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDky);
            this.Controls.Add(this.Phong);
            this.Controls.Add(this.DSP);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FTimphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTimphong";
            this.Load += new System.EventHandler(this.FTimphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox tang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnTimkiem;
        private System.Windows.Forms.ComboBox gia;
        private System.Windows.Forms.ComboBox loaiphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView DSP;
        private System.Windows.Forms.ListView Phong;
        private System.Windows.Forms.Button BtnDky;
    }
}