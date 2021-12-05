
namespace PhanMemQuanLySinhVien
{
    partial class Form3
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMonHoc = new System.Windows.Forms.TextBox();
            this.dataGridViewMonHoc = new System.Windows.Forms.DataGridView();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(210, 333);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 46);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(114, 333);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(60, 46);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(17, 333);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 46);
            this.btnThem.TabIndex = 17;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(608, 84);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(86, 32);
            this.btnTim.TabIndex = 16;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimMonHoc
            // 
            this.txtTimMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimMonHoc.Location = new System.Drawing.Point(434, 89);
            this.txtTimMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimMonHoc.Name = "txtTimMonHoc";
            this.txtTimMonHoc.Size = new System.Drawing.Size(149, 22);
            this.txtTimMonHoc.TabIndex = 15;
            this.txtTimMonHoc.TextChanged += new System.EventHandler(this.txtTimMonHoc_TextChanged);
            // 
            // dataGridViewMonHoc
            // 
            this.dataGridViewMonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonHoc.Location = new System.Drawing.Point(300, 144);
            this.dataGridViewMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            this.dataGridViewMonHoc.RowHeadersWidth = 51;
            this.dataGridViewMonHoc.RowTemplate.Height = 24;
            this.dataGridViewMonHoc.Size = new System.Drawing.Size(394, 248);
            this.dataGridViewMonHoc.TabIndex = 14;
            this.dataGridViewMonHoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMonHoc_CellDoubleClick);
            // 
            // txtTenMonHoc
            // 

            this.txtTenMonHoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonHoc.Location = new System.Drawing.Point(186, 266);
            this.txtTenMonHoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);

            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(136, 22);
            this.txtTenMonHoc.TabIndex = 13;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaMonHoc.Location = new System.Drawing.Point(144, 199);
            this.txtMaMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.ReadOnly = true;
            this.txtMaMonHoc.Size = new System.Drawing.Size(100, 22);
            this.txtMaMonHoc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên Môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quản lý môn học";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(714, 449);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtTimMonHoc);
            this.Controls.Add(this.dataGridViewMonHoc);
            this.Controls.Add(this.txtTenMonHoc);
            this.Controls.Add(this.txtMaMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMonHoc;
        private System.Windows.Forms.DataGridView dataGridViewMonHoc;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}