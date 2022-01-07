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
        int stt;

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
            KHOA kHOA = qlsv.KHOAs.Where(h => h.MaKhoa == stt).First();
            kHOA.TenKhoa = txtTenKhoa.Text;

            qlsv.SaveChanges();

            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KHOA khoa = new KHOA();
            khoa.TenKhoa = txtTenKhoa.Text;
            qlsv.KHOAs.Add(khoa);
            qlsv.SaveChanges();
            loadData();

            xoaKiTu();


        }

        public void loadData()
        {
            dataGridViewKhoa.DataSource = qlsv.KHOAs.Select(s => new { s.MaKhoa, s.TenKhoa }).ToList();

        }

        public void xoaKiTu()
        {
            txtMaKhoa.Text = string.Empty;
            txtTenKhoa.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dataGridViewKhoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = Convert.ToInt32(dataGridViewKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString());
            txtMaKhoa.Text = dataGridViewKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString();
            txtTenKhoa.Text = dataGridViewKhoa.Rows[e.RowIndex].Cells["TenKhoa"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

           DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtMaKhoa.Text);

                var sv = qlsv.KHOAs.Where(x => x.MaKhoa == id).First();
                qlsv.KHOAs.Remove(sv);
                qlsv.SaveChanges();
                loadData();
            }


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
