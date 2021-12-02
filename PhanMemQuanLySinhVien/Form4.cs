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
        int stt;
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form4()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            dataGridView1.DataSource = qlsv.SINHVIENs.Join(
                qlsv.LOPs,//bảng cần nối
                s => s.MaLop, //khóa ngoại của bảng SV
                q => q.MaLop, //khóa chính của bảng LOP
                (s, q) => new
                {
                    MaSV = s.MaSV,
                    Hoten = s.HoTen,
                    Gioitinh = s.GioiTinh,
                    NTNS = s.NTNS,
                    DiaChi = s.DiaChi,

                    TenLop = q.TenLop
                }
                ).ToList();
      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = new SINHVIEN();
            sv.HoTen = txtHoTen.Text;
            sv.GioiTinh = cbGioiTinh.Text;
            sv.NTNS = Convert.ToDateTime(dateTimeNTNS.Text);//convert sang ngày tháng
            sv.DiaChi = txtDiaChi.Text;
            sv.MaLop = Convert.ToInt32(cbLop.SelectedValue.ToString());

            qlsv.SINHVIENs.Add(sv);
            qlsv.SaveChanges();

            loadData();
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadData();
            cbLop.DisplayMember = "TenLop";//hiển thị cột TenLop lên Combo box
            cbLop.ValueMember = "MaLop"; // Khi hiển thị rồi mà người dùng chọn thì nó lấy cột MaLop

            cbLop.DataSource = qlsv.LOPs.ToList();//hiển thị dữ liệu từ DB lên combo box
        }

        private void dateTimeNTNS_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = qlsv.SINHVIENs.Where(h => h.MaSV == stt).First();
            sv.HoTen = txtHoTen.Text;
            sv.GioiTinh = cbGioiTinh.Text;
            sv.NTNS = Convert.ToDateTime(dateTimeNTNS.Text);
            sv.DiaChi = txtDiaChi.Text;
            sv.MaLop = Convert.ToInt32(cbLop.SelectedValue.ToString());

            qlsv.SaveChanges();

            loadData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stt = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MaSV"].Value.ToString());
            txtMaSinhVien.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSV"].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            cbGioiTinh.Text = dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value.ToString();
            dateTimeNTNS.Text = dataGridView1.Rows[e.RowIndex].Cells["NTNS"].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value.ToString();
            cbLop.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
        }
    }
}
