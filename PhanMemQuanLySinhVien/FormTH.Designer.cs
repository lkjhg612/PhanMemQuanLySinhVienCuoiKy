
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDoiTuongDN = new System.Windows.Forms.Label();
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLTTSV = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQLDSV = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQLND = new System.Windows.Forms.Button();
            this.btnQuanLyKhoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnQLDSV);
            this.panel1.Controls.Add(this.btnQuanLyLop);
            this.panel1.Controls.Add(this.btnQLND);
            this.panel1.Controls.Add(this.btnQuanLyKhoa);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 557);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbDoiTuongDN
            // 
            this.lbDoiTuongDN.AutoSize = true;
            this.lbDoiTuongDN.Location = new System.Drawing.Point(82, 51);
            this.lbDoiTuongDN.Name = "lbDoiTuongDN";
            this.lbDoiTuongDN.Size = new System.Drawing.Size(99, 17);
            this.lbDoiTuongDN.TabIndex = 2;
            this.lbDoiTuongDN.Text = "@USERNAME";
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Location = new System.Drawing.Point(93, 20);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(99, 17);
            this.lbTenNguoiDung.TabIndex = 2;
            this.lbTenNguoiDung.Text = "@USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đối tượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào mừng:";
            // 
            // btnQLTTSV
            // 
            this.btnQLTTSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLTTSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTTSV.Location = new System.Drawing.Point(0, 260);
            this.btnQLTTSV.Name = "btnQLTTSV";
            this.btnQLTTSV.Size = new System.Drawing.Size(254, 46);
            this.btnQLTTSV.TabIndex = 1;
            this.btnQLTTSV.Text = "Quản lý thông tin sinh viên";
            this.btnQLTTSV.UseVisualStyleBackColor = false;
            this.btnQLTTSV.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQLMH
            // 
            this.btnQLMH.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLMH.Location = new System.Drawing.Point(0, 219);
            this.btnQLMH.Name = "btnQLMH";
            this.btnQLMH.Size = new System.Drawing.Size(254, 46);
            this.btnQLMH.TabIndex = 1;
            this.btnQLMH.Text = "Quản lý môn học";
            this.btnQLMH.UseVisualStyleBackColor = false;
            this.btnQLMH.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.MistyRose;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Location = new System.Drawing.Point(-2, 511);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(257, 46);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(0, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quản lý thời khóa biểu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQLDSV
            // 
            this.btnQLDSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLDSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDSV.Location = new System.Drawing.Point(0, 302);
            this.btnQLDSV.Name = "btnQLDSV";
            this.btnQLDSV.Size = new System.Drawing.Size(254, 46);
            this.btnQLDSV.TabIndex = 1;
            this.btnQLDSV.Text = "Quản lý điểm sinh viên";
            this.btnQLDSV.UseVisualStyleBackColor = false;
            this.btnQLDSV.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQuanLyLop
            // 
            this.btnQuanLyLop.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuanLyLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyLop.Location = new System.Drawing.Point(0, 177);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(254, 46);
            this.btnQuanLyLop.TabIndex = 1;
            this.btnQuanLyLop.Text = "Quản lý lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = false;
            this.btnQuanLyLop.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQLND
            // 
            this.btnQLND.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLND.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLND.Location = new System.Drawing.Point(1, 469);
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.Size = new System.Drawing.Size(254, 46);
            this.btnQLND.TabIndex = 1;
            this.btnQLND.Text = "Quản lý người dùng";
            this.btnQLND.UseVisualStyleBackColor = false;
            this.btnQLND.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQuanLyKhoa
            // 
            this.btnQuanLyKhoa.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuanLyKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhoa.Location = new System.Drawing.Point(0, 135);
            this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
            this.btnQuanLyKhoa.Size = new System.Drawing.Size(254, 46);
            this.btnQuanLyKhoa.TabIndex = 1;
            this.btnQuanLyKhoa.Text = "Quản lý khoa";
            this.btnQuanLyKhoa.UseVisualStyleBackColor = false;
            this.btnQuanLyKhoa.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // FormTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1213, 563);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormTH";
            this.Padding = new System.Windows.Forms.Padding(255, 0, 0, 0);
            this.Text = "FormTH";
            this.Load += new System.EventHandler(this.FormTH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
    }
}