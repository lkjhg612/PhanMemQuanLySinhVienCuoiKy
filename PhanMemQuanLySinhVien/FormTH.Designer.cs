
namespace PhanMemQuanLySinhVien
{
    partial class FormTH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDoiTuongDN = new System.Windows.Forms.Label();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLTTSV = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnQLDSV = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQLND = new System.Windows.Forms.Button();
            this.btnQuanLyKhoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.lbDoiTuongDN);
            this.panel1.Controls.Add(this.lbTenNguoiDung);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQLTTSV);
            this.panel1.Controls.Add(this.btnQLMH);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnQLDSV);
            this.panel1.Controls.Add(this.btnQuanLyLop);
            this.panel1.Controls.Add(this.btnQLND);
            this.panel1.Controls.Add(this.btnQuanLyKhoa);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 453);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbDoiTuongDN
            // 
            this.lbDoiTuongDN.AutoSize = true;
            this.lbDoiTuongDN.Location = new System.Drawing.Point(62, 41);
            this.lbDoiTuongDN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoiTuongDN.Name = "lbDoiTuongDN";
            this.lbDoiTuongDN.Size = new System.Drawing.Size(79, 13);
            this.lbDoiTuongDN.TabIndex = 2;
            this.lbDoiTuongDN.Text = "@USERNAME";
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(70, 16);
            this.lbTenNguoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(79, 13);
            this.lbTenNguoiDung.TabIndex = 2;
            this.lbTenNguoiDung.Text = "@USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đối tượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào mừng:";
            // 
            // btnQLTTSV
            // 
            this.btnQLTTSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLTTSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTTSV.Location = new System.Drawing.Point(0, 211);
            this.btnQLTTSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLTTSV.Name = "btnQLTTSV";
            this.btnQLTTSV.Size = new System.Drawing.Size(190, 37);
            this.btnQLTTSV.TabIndex = 1;
            this.btnQLTTSV.Text = "Quản lý thông tin sinh viên";
            this.btnQLTTSV.UseVisualStyleBackColor = false;
            this.btnQLTTSV.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLMH.Location = new System.Drawing.Point(0, 178);
            this.btnQLMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(190, 37);
            this.btnQLMH.TabIndex = 1;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = false;
            this.btnQLMH.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.MistyRose;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Location = new System.Drawing.Point(-2, 415);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 37);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MistyRose;
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Location = new System.Drawing.Point(0, 276);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(190, 37);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê sinh viên";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQLDSV
            // 
            this.btnQLDSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLDSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDSV.Location = new System.Drawing.Point(0, 245);
            this.btnQLDSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLDSV.Name = "btnQLDSV";
            this.btnQLDSV.Size = new System.Drawing.Size(190, 37);
            this.btnQLDSV.TabIndex = 1;
            this.btnQLDSV.Text = "Quản lý điểm sinh viên";
            this.btnQLDSV.UseVisualStyleBackColor = false;
            this.btnQLDSV.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuanLyLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyLop.Location = new System.Drawing.Point(0, 144);
            this.btnQuanLyLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(190, 37);
            this.btnQuanLyLop.TabIndex = 1;
            this.btnQuanLyLop.Text = "Quản lý lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = false;
            this.btnQuanLyLop.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQLND
            // 
            this.btnQLND.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLND.Location = new System.Drawing.Point(1, 381);
            this.btnQLND.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.Size = new System.Drawing.Size(190, 37);
            this.btnQLND.TabIndex = 1;
            this.btnQLND.Text = "Quản lý người dùng";
            this.btnQLND.UseVisualStyleBackColor = false;
            this.btnQLND.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQuanLyKhoa
            // 
            this.btnQuanLyKhoa.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuanLyKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhoa.Location = new System.Drawing.Point(0, 110);
            this.btnQuanLyKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
            this.btnQuanLyKhoa.Size = new System.Drawing.Size(190, 37);
            this.btnQuanLyKhoa.TabIndex = 1;
            this.btnQuanLyKhoa.Text = "Quản lý khoa";
            this.btnQuanLyKhoa.UseVisualStyleBackColor = false;
            this.btnQuanLyKhoa.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Algerian", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(337, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "WELCOME TO THIS APP";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMemQuanLySinhVien.Properties.Resources.R__1_;
            this.pictureBox1.Location = new System.Drawing.Point(194, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 357);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTH";
            this.Padding = new System.Windows.Forms.Padding(191, 0, 0, 0);
            this.Text = "FormTH";
            this.Load += new System.EventHandler(this.FormTH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTenNguoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLTTSV;
        private System.Windows.Forms.Button btnQLMH;
        private System.Windows.Forms.Button btnQLDSV;
        private System.Windows.Forms.Button btnQuanLyLop;
        private System.Windows.Forms.Button btnDangXuat;
        public System.Windows.Forms.Button btnQuanLyKhoa;
        public System.Windows.Forms.Button btnQLND;
        private System.Windows.Forms.Label lbDoiTuongDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
    }
}