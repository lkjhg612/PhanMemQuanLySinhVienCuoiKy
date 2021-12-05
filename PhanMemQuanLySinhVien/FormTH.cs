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
            /*MessageBox.Show("S");*/

            if(form1 == null){
                form1 = new Form1();
                form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form1.StartPosition = FormStartPosition.Manual;
                form1.MdiParent = this;
                form1.Show();
            }
            else
            {
                form1.loadData();
                form1.Activate();
            }
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
                form2.loadData();
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
                form3.loadData();
                form3.Activate();
            }
        }
        private void btnQLTTSV_Clicked()
        {
            /*MessageBox.Show("S");*/
            if (form4 == null)
            {
                form4 = new Form4();
                form4.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form4.StartPosition = FormStartPosition.Manual;
                form4.MdiParent = this;
                form4.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                form4.loadData();
                form4.Activate();
            }

        }
        private void btnQLDSV_Clicked()
        {
            /* MessageBox.Show("S");*/
            if (form5 == null)
            {
                form5 = new Form5();
                form5.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form5.StartPosition = FormStartPosition.Manual;
                form5.MdiParent = this;
                form5.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                form5.loadData();
                form5.Activate();
            }

        }
        private void btnDangXuat_Clicked()
        {
            /*MessageBox.Show("S");*/
            if (form6 == null)
            {
                form6 = new Form6();
                this.Close();
                form6.StartPosition = FormStartPosition.CenterScreen;
                form6.Show();
            }
            
        }

        private void FormTH_Load(object sender, EventArgs e)
        {
            lbTenNguoiDung.Text = username;
        }
    }
}
