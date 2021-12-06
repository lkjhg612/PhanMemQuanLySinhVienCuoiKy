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
    public partial class Form7 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form7()
        {
            InitializeComponent();
        }

        public void loadData()
        {

            dataGridViewND.DataSource = qlsv.NGUOIDUNGs.Select(s => new
            {
               s.ID_ND,
               s.TenNguoiDung,
               s.TaiKhoan,
               s.MatKhau,
               s.QUYEN.TenQuyen
            }).ToList();

            cbQuyen.DisplayMember = "TenQuyen";
            cbQuyen.ValueMember = "ID_Quyen";
            cbQuyen.DataSource = qlsv.QUYENs.ToList();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
