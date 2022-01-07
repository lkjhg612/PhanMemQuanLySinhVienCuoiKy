
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
            this.datefirstTKB = new System.Windows.Forms.DateTimePicker();
            this.datelasttkb = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.cbxBuoi = new System.Windows.Forms.ComboBox();
            this.cbxThu = new System.Windows.Forms.ComboBox();
            this.cbxMH = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.gvtkb = new System.Windows.Forms.DataGridView();
            this.btn_XoaTKB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_SuaTKB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ThemTKB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvtkb)).BeginInit();
            this.SuspendLayout();
            // 
            // datefirstTKB
            // 
            this.datefirstTKB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datefirstTKB.Location = new System.Drawing.Point(105, 78);
            this.datefirstTKB.Margin = new System.Windows.Forms.Padding(2);
            this.datefirstTKB.Name = "datefirstTKB";
            this.datefirstTKB.Size = new System.Drawing.Size(133, 20);
            this.datefirstTKB.TabIndex = 36;
            // 
            // datelasttkb
            // 
            this.datelasttkb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datelasttkb.Location = new System.Drawing.Point(106, 110);
            this.datelasttkb.Margin = new System.Windows.Forms.Padding(2);
            this.datelasttkb.Name = "datelasttkb";
            this.datelasttkb.Size = new System.Drawing.Size(132, 20);
            this.datelasttkb.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Quản lý thời khóa biểu";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(94, 305);
            this.txtTenGV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(144, 20);
            this.txtTenGV.TabIndex = 33;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Location = new System.Drawing.Point(94, 145);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(144, 21);
            this.cbxKhoa.TabIndex = 32;
            // 
            // cbxBuoi
            // 
            this.cbxBuoi.FormattingEnabled = true;
            this.cbxBuoi.Location = new System.Drawing.Point(94, 269);
            this.cbxBuoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbxBuoi.Name = "cbxBuoi";
            this.cbxBuoi.Size = new System.Drawing.Size(144, 21);
            this.cbxBuoi.TabIndex = 31;
            // 
            // cbxThu
            // 
            this.cbxThu.FormattingEnabled = true;
            this.cbxThu.Location = new System.Drawing.Point(94, 241);
            this.cbxThu.Margin = new System.Windows.Forms.Padding(2);
            this.cbxThu.Name = "cbxThu";
            this.cbxThu.Size = new System.Drawing.Size(144, 21);
            this.cbxThu.TabIndex = 30;
            // 
            // cbxMH
            // 
            this.cbxMH.FormattingEnabled = true;
            this.cbxMH.Location = new System.Drawing.Point(94, 209);
            this.cbxMH.Margin = new System.Windows.Forms.Padding(2);
            this.cbxMH.Name = "cbxMH";
            this.cbxMH.Size = new System.Drawing.Size(144, 21);
            this.cbxMH.TabIndex = 29;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(94, 176);
            this.cbxLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(144, 21);
            this.cbxLop.TabIndex = 28;
            // 
            // gvtkb
            // 
            this.gvtkb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvtkb.Location = new System.Drawing.Point(253, 78);
            this.gvtkb.Margin = new System.Windows.Forms.Padding(2);
            this.gvtkb.Name = "gvtkb";
            this.gvtkb.RowHeadersWidth = 51;
            this.gvtkb.RowTemplate.Height = 24;
            this.gvtkb.Size = new System.Drawing.Size(476, 361);
            this.gvtkb.TabIndex = 27;
            // 
            // btn_XoaTKB
            // 
            this.btn_XoaTKB.Location = new System.Drawing.Point(181, 361);
            this.btn_XoaTKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_XoaTKB.Name = "btn_XoaTKB";
            this.btn_XoaTKB.Size = new System.Drawing.Size(56, 19);
            this.btn_XoaTKB.TabIndex = 26;
            this.btn_XoaTKB.Text = "Xóa";
            this.btn_XoaTKB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 309);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Giảng viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "buổi:";
            // 
            // btn_SuaTKB
            // 
            this.btn_SuaTKB.Location = new System.Drawing.Point(106, 361);
            this.btn_SuaTKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SuaTKB.Name = "btn_SuaTKB";
            this.btn_SuaTKB.Size = new System.Drawing.Size(56, 19);
            this.btn_SuaTKB.TabIndex = 24;
            this.btn_SuaTKB.Text = "Sửa";
            this.btn_SuaTKB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 82);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Ngày bắt đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Thứ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ngày kết thúc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Môn học";
            // 
            // btn_ThemTKB
            // 
            this.btn_ThemTKB.Location = new System.Drawing.Point(35, 361);
            this.btn_ThemTKB.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemTKB.Name = "btn_ThemTKB";
            this.btn_ThemTKB.Size = new System.Drawing.Size(56, 19);
            this.btn_ThemTKB.TabIndex = 25;
            this.btn_ThemTKB.Text = "Thêm thời khóa biểu";
            this.btn_ThemTKB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lớp:";
            // 
            // FormTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.DateTimePicker datefirstTKB;
        private System.Windows.Forms.DateTimePicker datelasttkb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.ComboBox cbxBuoi;
        private System.Windows.Forms.ComboBox cbxThu;
        private System.Windows.Forms.ComboBox cbxMH;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.DataGridView gvtkb;
        private System.Windows.Forms.Button btn_XoaTKB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_SuaTKB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ThemTKB;
        private System.Windows.Forms.Label label1;
    }
}