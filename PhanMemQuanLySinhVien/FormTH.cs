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
        NGUOIDUNG nd;
        int? id_Quyen;

        FormKhoa form1;
        FormLop form2;
        FormMonHoc form3;
        FormTTSV form4;
        FormDiemSV form5;
        FormDangNhap form6;
        FormTTND form7;
        FormSVDangNhap form8;
        FormThongKe thongKe;
        FormTKB formTKB;

        public FormTH(NGUOIDUNG nd)
        {
            InitializeComponent();
            this.nd = nd;
        }



        private void AllBtn_Click(object sender, EventArgs e)
        {
            Button clicked = (Button) sender;
            foreach (Control control in panel1.Controls)
            {
                control.BackColor = Color.MistyRose;
            }
            clicked.BackColor = Color.Coral;

            pictureBox1.BackColor = Color.SandyBrown;
            pictureBox2.BackColor = Color.SandyBrown;
            label1.BackColor = Color.SandyBrown;
            label2.BackColor = Color.SandyBrown;
            lbTenNguoiDung.BackColor = Color.SandyBrown;
            lbDoiTuongDN.BackColor = Color.SandyBrown;

            String idname = clicked.Name;
            switch (idname)
            {
                case "btnQuanLyKhoa": btnQuanLyKhoa_Clicked(); break;
                case "btnQuanLyLop": btnQuanLyLop_Clicked(); break;
                case "btnQLMH": btnQLMH_Clicked(); break;
                case "btnQLTTSV": btnQLTTSV_Clicked(); break;
                case "btnQLDSV": btnQLDSV_Clicked(); break;
                case "btnDangXuat": btnDangXuat_Clicked() ; break;
                case "btnQLND": btnQLND_Clicked(); break;
                case "btnThongKe": btnThongKe_Clicked(); break;
                case "btnQLTKB": btnQuanLyTKB_Clicked(); break;
            }


        }

        private void btnQuanLyTKB_Clicked()
        {
            /*MessageBox.Show("S");*/

            if (formTKB == null)
            {
                formTKB = new FormTKB();
                formTKB.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formTKB.StartPosition = FormStartPosition.Manual;
                formTKB.MdiParent = this;
                formTKB.Show();

                if (nd.ID_Quyen == 2)
                {
                    formTKB.btn_ThemTKB.Enabled = false;
                    formTKB.btn_SuaTKB.Enabled = false;
                    formTKB.btn_XoaTKB.Enabled = false;
                }

            }
            else
            {
                formTKB.loaddata();
                formTKB.Activate();

                if (nd.ID_Quyen == 2)
                {
                    formTKB.btn_ThemTKB.Enabled = false;
                    formTKB.btn_SuaTKB.Enabled = false;
                    formTKB.btn_XoaTKB.Enabled = false;
                }

            }
        }

        private void btnQuanLyKhoa_Clicked()
        {
            /*MessageBox.Show("S");*/
            
            if(form1 == null){
                form1 = new FormKhoa();
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
                form2 = new FormLop();
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
                form3 = new FormMonHoc();
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
                form4 =  new FormTTSV();
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
                form5 = new FormDiemSV();
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
                form6 = new FormDangNhap();
                this.Close();
                form6.StartPosition = FormStartPosition.CenterScreen;
                form6.Show();
            }
            
        }

        private void btnQLND_Clicked()
        {
            if (form7 == null)
            {
                form7 = new FormTTND();
                form7.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                form7.StartPosition = FormStartPosition.Manual;
                form7.MdiParent = this;
                form7.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                form7.loadData();
                form7.Activate();
            }
        }

        private void btnThongKe_Clicked()
        {
            if (thongKe == null)
            {
                thongKe = new FormThongKe();
                thongKe.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                thongKe.StartPosition = FormStartPosition.Manual;
                thongKe.MdiParent = this;
                thongKe.Show();
            }
            else
            {
                //QuanLyCaffe quanLyCaffe = new QuanLyCaffe();
                //form3.dataGridView2.DataSource = quanLyCaffe.hienThiMatHang();
                thongKe.Activate();
            }
        }

        private void FormTH_Load(object sender, EventArgs e)
        {
            lbTenNguoiDung.Text = nd.TenNguoiDung;
            lbDoiTuongDN.Text = nd.QUYEN.MoTa;


            id_Quyen = nd.ID_Quyen;

            if (id_Quyen == 3)
            {
                btnQuanLyKhoa.Visible = false;
                btnQuanLyLop.Visible = false;
                btnQLDSV.Visible = false;
                btnQLND.Visible = false;
                btnQLDSV.Visible = false;
                btnQLMH.Visible = false;
                btnQLTTSV.Visible = false;
                btnThongKe.Visible = false;
                btnQLTKB.Visible = false;


                if (form8 == null)
                {
                    form8 = new FormSVDangNhap(nd);
                    form8.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    form8.StartPosition = FormStartPosition.Manual;
                    form8.MdiParent = this;
                    form8.Show();
                }
                else
                {
                    form8.Activate();
                }

            } else if (id_Quyen == 2)
            {
                btnQuanLyKhoa.Enabled = false;
                btnQuanLyLop.Enabled = false;
                btnQLMH.Enabled = false;
                btnQLND.Enabled = false;
                
            }

        }

        private void LockEnable(Control control)
        {
            control.Enabled = false;
            //control.Enable
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
