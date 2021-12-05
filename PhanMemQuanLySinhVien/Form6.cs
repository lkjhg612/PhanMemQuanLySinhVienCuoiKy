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
    public partial class Form6 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String taiKhoan = txtTenDangNhap.Text;
            String matKhau = txtMatKhau.Text;

            List<NGUOIDUNG> users = qlsv.NGUOIDUNGs.Where(h => h.TaiKhoan == taiKhoan && h.MatKhau == matKhau).ToList();

            if (users.Count == 0)
            {
                MessageBox.Show("SAI TÊN TK HOẶC MK");
            } else
            {
                NGUOIDUNG ND = users.First(); //Lấy phần tử đầu tiên của list users và gán vào biến nd có kiểu NGUOIDUNG

                FormTH formTH = new FormTH(ND);
                formTH.Show();
                this.Hide();
            }

        }

        private void cbHien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHien.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            } else
            {
                txtMatKhau.UseSystemPasswordChar = true;
            }
        }
    }
}
