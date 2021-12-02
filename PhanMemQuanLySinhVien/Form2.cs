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

       
    }
}
