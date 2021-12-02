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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtMaMonHoc.Text);

            var sv = qlsv.MONHOCs.Where(x => x.MaMH == ID).First();
            qlsv.MONHOCs.Remove(sv);
            qlsv.SaveChanges();
            loadData();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtTimMonHoc.Text);

            dataGridViewMonHoc.DataSource = qlsv.MONHOCs.Where(x => x.MaMH == ID).ToList();
        }

        private void txtTimMonHoc_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTimMonHoc.Text))
            {
                loadData();
            }
        }
    }
}
