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
    public partial class Form1 : Form
    {

        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMaKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaKhoa.Text);

            var sv = qlsv.KHOAs.Where(x => x.MaKhoa == id).First();
            qlsv.KHOAs.Remove(sv);
            qlsv.SaveChanges();
            loadData();
        }

        private void loadData()
        {
            dataGridViewKhoa.DataSource = qlsv.KHOAs.Select(c => new { c.MaKhoa, c.TenKhoa }).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTim.Text);
            dataGridViewKhoa.DataSource = qlsv.KHOAs.Where(x => x.MaKhoa == id).Select(x => new { x.MaKhoa, x.TenKhoa }).ToList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTim.Text))
            {
                loadData();
            }
        }
    }
}
