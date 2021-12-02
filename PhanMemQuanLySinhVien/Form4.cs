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
    public partial class Form4 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form4()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            dataGridView1.DataSource = qlsv.SINHVIENs.ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
