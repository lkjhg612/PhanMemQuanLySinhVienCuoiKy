using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLySinhVien
{
    public partial class FormTH : Form
    {
        String username;

        Form1 form1;
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        Form6 form6;
        public FormTH(String UN)
        {
            InitializeComponent();
            username = UN;
        }

        private void AllBtn_Click(object sender, EventArgs e)
        {
            Button clicked = (Button) sender;
            foreach (Control control in panel1.Controls)
            {
                control.BackColor = Color.MistyRose;
            }
            clicked.BackColor = Color.Coral;

            String idname = clicked.Name;
            switch (idname)
            {
                case "btnQuanLyKhoa": btnQuanLyKhoa_Clicked(); break;
                case "btnQuanLyLop": btnQuanLyLop_Clicked(); break;
                case "btnQLMH": btnQLMH_Clicked(); break;
                case "btnQLTTSV": btnQLTTSV_Clicked(); break;
                case "btnQLDSV": btnQLDSV_Clicked(); break;
                case "btnDangXuat": btnDangXuat_Clicked() ; break;

            }


        }

        private void btnQuanLyKhoa_Clicked()
        {
            MessageBox.Show("S");
        }
        private void btnQuanLyLop_Clicked()
        {
            if (form2 == null)
            {
                form2 = new Form2();
                form2.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form2.StartPosition = FormStartPosition.Manual;
                form2.MdiParent = this;
                form2.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                form2.Activate();
            }
        }
        private void btnQLMH_Clicked()
        {
            if (form3 == null)
            {
                form3 = new Form3();
                form3.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form3.StartPosition = FormStartPosition.Manual;
                form3.MdiParent = this;
                form3.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                form3.Activate();
            }
        }
        private void btnQLTTSV_Clicked()
        {
            MessageBox.Show("S");
        }
        private void btnQLDSV_Clicked()
        {
            MessageBox.Show("S");
        }
        private void btnDangXuat_Clicked()
        {
            this.Close();
            form6 = new Form6();
            form6.Show();
        }

        private void FormTH_Load(object sender, EventArgs e)
        {
            lbTenNguoiDung.Text = username;
        }
    }
}
