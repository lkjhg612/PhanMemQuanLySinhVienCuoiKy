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
    public partial class Form3 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form3()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            dataGridViewMonHoc.DataSource = qlsv.MONHOCs.ToList();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
