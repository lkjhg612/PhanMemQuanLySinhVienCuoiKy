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
    public partial class Form2 : Form
    {

        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            dataGridViewLop.DataSource = qlsv.LOPs.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtMaLop.Text);

            var lop = qlsv.LOPs.Where(h => h.MaLop == id).First();
            qlsv.LOPs.Remove(lop);
            qlsv.SaveChanges();
            loadData();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtTim.Text);
            dataGridViewLop.DataSource = qlsv.LOPs.Where(x => x.MaLop == id).Select(x => new { x.MaLop, x.TenLop }).ToList();
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
