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
        int stt;
        public Form3()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            dataGridViewMonHoc.DataSource = qlsv.MONHOCs.Select(s => new 
            {
            s.MaMH,
            s.TenMH
            }).ToList();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            MONHOC mh = new MONHOC();
            mh.TenMH = txtTenMonHoc.Text;
            qlsv.MONHOCs.Add(mh);
            qlsv.SaveChanges();
            loadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MONHOC mh = qlsv.MONHOCs.Where(h => h.MaMH == stt).First();
            mh.TenMH = txtTenMonHoc.Text;
            qlsv.SaveChanges();
            loadData();
        }

        private void dataGridViewMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = Convert.ToInt32( dataGridViewMonHoc.Rows[e.RowIndex].Cells["MaMH"].Value.ToString());
            txtMaMonHoc.Text = dataGridViewMonHoc.Rows[e.RowIndex].Cells["MaMH"].Value.ToString();
            txtTenMonHoc.Text = dataGridViewMonHoc.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
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
