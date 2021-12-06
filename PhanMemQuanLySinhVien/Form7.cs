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
        int id;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            NGUOIDUNG nd = new NGUOIDUNG();
            nd.TenNguoiDung = txtTenNgDung.Text;
            nd.TaiKhoan = txtTaiKhoan.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.ID_Quyen = Convert.ToInt32(cbQuyen.SelectedValue.ToString());

            qlsv.NGUOIDUNGs.Add(nd);
            qlsv.SaveChanges();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maId = Convert.ToInt32(txtID.Text);
            NGUOIDUNG nd = qlsv.NGUOIDUNGs.Where(h => h.ID_ND == maId).First();

            nd.TenNguoiDung = txtTenNgDung.Text;
            nd.TaiKhoan = txtTaiKhoan.Text;
            nd.MatKhau = txtMatKhau.Text;
            nd.ID_Quyen = Convert.ToInt32(cbQuyen.SelectedValue.ToString());

            qlsv.SaveChanges();
            loadData();

        }

        private void dataGridViewND_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewND.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = (dataGridViewND.Rows[e.RowIndex].Cells["ID_ND"].Value.ToString());
            txtTenNgDung.Text =(dataGridViewND.Rows[e.RowIndex].Cells["TenNguoiDung"].Value.ToString());
            txtTaiKhoan.Text = (dataGridViewND.Rows[e.RowIndex].Cells["TaiKhoan"].Value.ToString());
            txtMatKhau.Text = (dataGridViewND.Rows[e.RowIndex].Cells["MatKhau"].Value.ToString());
            cbQuyen.Text = (dataGridViewND.Rows[e.RowIndex].Cells["TenQuyen"].Value.ToString());
        }
    }
}
