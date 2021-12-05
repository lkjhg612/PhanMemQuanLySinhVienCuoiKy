
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
            this.lbTenNguoiDung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLTTSV = new System.Windows.Forms.Button();
            this.btnQLMH = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnQLDSV = new System.Windows.Forms.Button();
            this.btnQuanLyLop = new System.Windows.Forms.Button();
            this.btnQuanLyKhoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.lbTenNguoiDung);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQLTTSV);
            this.panel1.Controls.Add(this.btnQLMH);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnQLDSV);
            this.panel1.Controls.Add(this.btnQuanLyLop);
            this.panel1.Controls.Add(this.btnQuanLyKhoa);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 453);
            this.panel1.TabIndex = 0;
            // 
            // lbTenNguoiDung
            // 
            this.lbTenNguoiDung.AutoSize = true;
            this.lbTenNguoiDung.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNguoiDung.Location = new System.Drawing.Point(29, 37);
            this.lbTenNguoiDung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenNguoiDung.Name = "lbTenNguoiDung";
            this.lbTenNguoiDung.Size = new System.Drawing.Size(134, 23);
            this.lbTenNguoiDung.TabIndex = 2;
            this.lbTenNguoiDung.Text = "@USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chào mừng đăng nhập ";
            // 
            // btnQLTTSV
            // 
            this.btnQLTTSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLTTSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLTTSV.Location = new System.Drawing.Point(0, 258);
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
            this.btnQLMH.Location = new System.Drawing.Point(0, 225);
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
            // btnQLDSV
            // 
            this.btnQLDSV.BackColor = System.Drawing.Color.MistyRose;
            this.btnQLDSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDSV.Location = new System.Drawing.Point(0, 292);
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
            this.btnQuanLyLop.Location = new System.Drawing.Point(0, 191);
            this.btnQuanLyLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanLyLop.Name = "btnQuanLyLop";
            this.btnQuanLyLop.Size = new System.Drawing.Size(190, 37);
            this.btnQuanLyLop.TabIndex = 1;
            this.btnQuanLyLop.Text = "Quản lý lớp";
            this.btnQuanLyLop.UseVisualStyleBackColor = false;
            this.btnQuanLyLop.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // btnQuanLyKhoa
            // 
            this.btnQuanLyKhoa.BackColor = System.Drawing.Color.MistyRose;
            this.btnQuanLyKhoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuanLyKhoa.Location = new System.Drawing.Point(0, 157);
            this.btnQuanLyKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuanLyKhoa.Name = "btnQuanLyKhoa";
            this.btnQuanLyKhoa.Size = new System.Drawing.Size(190, 37);
            this.btnQuanLyKhoa.TabIndex = 1;
            this.btnQuanLyKhoa.Text = "Quản lý khoa";
            this.btnQuanLyKhoa.UseVisualStyleBackColor = false;
            this.btnQuanLyKhoa.Click += new System.EventHandler(this.AllBtn_Click);
            // 
            // FormTH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(910, 457);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTH";
            this.Padding = new System.Windows.Forms.Padding(191, 0, 0, 0);
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
        private System.Windows.Forms.Button btnQuanLyKhoa;
        private System.Windows.Forms.Button btnDangXuat;
    }
}