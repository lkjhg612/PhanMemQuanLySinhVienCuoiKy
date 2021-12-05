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
            dataGridViewLop.DataSource = qlsv.LOPs.Select(s => new 
            {
                s.MaLop,
                s.TenLop,
                s.KHOA.TenKhoa
            }).ToList();

            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DataSource = qlsv.KHOAs.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String lop = txtTenLop.Text;
            int khoa = Convert.ToInt32(cbKhoa.SelectedValue.ToString());
            LOP lOP = new LOP
            {
                TenLop = lop,
                MaKhoa = khoa
            };
            qlsv.LOPs.Add(lOP);
            qlsv.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String tenLop = txtTenLop.Text;
            int khoa = Convert.ToInt32(cbKhoa.SelectedValue.ToString());
            int ID = Convert.ToInt32(txtMaLop.Text);
            var SV = qlsv.LOPs.Where(x => x.MaLop == ID).First();
            SV.TenLop = tenLop;
            SV.MaKhoa = khoa;
            qlsv.SaveChanges();
            loadData();
        }

        private void dataGridViewLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dataGridViewLop.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTenLop.Text = dataGridViewLop.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbKhoa.Text = dataGridViewLop.Rows[e.RowIndex].Cells[2].Value.ToString();
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
            dataGridViewLop.DataSource = qlsv.LOPs.Where(x => x.MaLop == id).Select(x => new { x.MaLop, x.TenLop, x.KHOA.TenKhoa }).ToList();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTim.Text))
            {
                loadData();
            }

        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
