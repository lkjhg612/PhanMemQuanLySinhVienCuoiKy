
namespace PhanMemQuanLySinhVien
{
    partial class FormTKB
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ThemTKB = new System.Windows.Forms.Button();
            this.gvtkb = new System.Windows.Forms.DataGridView();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SuaTKB = new System.Windows.Forms.Button();
            this.btn_XoaTKB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxThu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxBuoi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datelasttkb = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datefirstTKB = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvtkb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lớp:";
            // 
            // btn_ThemTKB
            // 
            this.btn_ThemTKB.Location = new System.Drawing.Point(15, 449);
            this.btn_ThemTKB.Name = "btn_ThemTKB";
            this.btn_ThemTKB.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemTKB.TabIndex = 1;
            this.btn_ThemTKB.Text = "Thêm thời khóa biểu";
            this.btn_ThemTKB.UseVisualStyleBackColor = true;
            this.btn_ThemTKB.Click += new System.EventHandler(this.btn_ThemTKB_Click);
            // 
            // gvtkb
            // 
            this.gvtkb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvtkb.Location = new System.Drawing.Point(305, 101);
            this.gvtkb.Name = "gvtkb";
            this.gvtkb.RowHeadersWidth = 51;
            this.gvtkb.RowTemplate.Height = 24;
            this.gvtkb.Size = new System.Drawing.Size(635, 444);
            this.gvtkb.TabIndex = 2;
            this.gvtkb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvtkb_CellClick);
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(93, 222);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(191, 24);
            this.cbxLop.TabIndex = 3;
            this.cbxLop.SelectedIndexChanged += new System.EventHandler(this.cbxLop_SelectedIndexChanged);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(93, 380);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(191, 22);
            this.txtTenGV.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(439, 46);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quản lý thời khóa biểu";
            // 
            // btn_SuaTKB
            // 
            this.btn_SuaTKB.Location = new System.Drawing.Point(110, 449);
            this.btn_SuaTKB.Name = "btn_SuaTKB";
            this.btn_SuaTKB.Size = new System.Drawing.Size(75, 23);
            this.btn_SuaTKB.TabIndex = 1;
            this.btn_SuaTKB.Text = "Sửa";
            this.btn_SuaTKB.UseVisualStyleBackColor = true;
            this.btn_SuaTKB.Click += new System.EventHandler(this.btn_SuaTKB_Click);
            // 
            // btn_XoaTKB
            // 
            this.btn_XoaTKB.Location = new System.Drawing.Point(209, 449);
            this.btn_XoaTKB.Name = "btn_XoaTKB";
            this.btn_XoaTKB.Size = new System.Drawing.Size(75, 23);
            this.btn_XoaTKB.TabIndex = 1;
            this.btn_XoaTKB.Text = "Xóa";
            this.btn_XoaTKB.UseVisualStyleBackColor = true;
            this.btn_XoaTKB.Click += new System.EventHandler(this.btn_XoaTKB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa:";
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(93, 183);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(191, 24);
            this.cbxKhoa.TabIndex = 3;
            this.cbxKhoa.SelectedIndexChanged += new System.EventHandler(this.cbxKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn học";
            // 
            // cbxMH
            // 
            this.cbxMH.FormattingEnabled = true;
            this.cbxMH.Location = new System.Drawing.Point(93, 262);
            this.cbxMH.Name = "cbxMH";
            this.cbxMH.Size = new System.Drawing.Size(191, 24);
            this.cbxMH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thứ:";
            // 
            // cbxThu
            // 
            this.cbxThu.FormattingEnabled = true;
            this.cbxThu.Location = new System.Drawing.Point(93, 301);
            this.cbxThu.Name = "cbxThu";
            this.cbxThu.Size = new System.Drawing.Size(191, 24);
            this.cbxThu.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "buổi:";
            // 
            // cbxBuoi
            // 
            this.cbxBuoi.FormattingEnabled = true;
            this.cbxBuoi.Location = new System.Drawing.Point(93, 336);
            this.cbxBuoi.Name = "cbxBuoi";
            this.cbxBuoi.Size = new System.Drawing.Size(191, 24);
            this.cbxBuoi.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giảng viên";
            // 
            // datelasttkb
            // 
            this.datelasttkb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datelasttkb.Location = new System.Drawing.Point(110, 140);
            this.datelasttkb.Name = "datelasttkb";
            this.datelasttkb.Size = new System.Drawing.Size(174, 22);
            this.datelasttkb.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ngày bắt đầu";
            // 
            // datefirstTKB
            // 
            this.datefirstTKB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefirstTKB.Location = new System.Drawing.Point(108, 101);
            this.datefirstTKB.Name = "datefirstTKB";
            this.datefirstTKB.Size = new System.Drawing.Size(176, 22);
            this.datefirstTKB.TabIndex = 15;
            // 
            // FormTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 553);
            this.Controls.Add(this.datefirstTKB);
            this.Controls.Add(this.datelasttkb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.cbxBuoi);
            this.Controls.Add(this.cbxThu);
            this.Controls.Add(this.cbxMH);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.gvtkb);
            this.Controls.Add(this.btn_XoaTKB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SuaTKB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ThemTKB);
            this.Controls.Add(this.label1);
            this.Name = "FormTKB";
            this.Text = "FormTKB";
            ((System.ComponentModel.ISupportInitialize)(this.gvtkb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ThemTKB;
        private System.Windows.Forms.DataGridView gvtkb;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SuaTKB;
        private System.Windows.Forms.Button btn_XoaTKB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxThu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxBuoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datelasttkb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datefirstTKB;
    }
}