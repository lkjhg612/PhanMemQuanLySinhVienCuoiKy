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
    public partial class FormDiemSV : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        int mmh;
        public FormDiemSV()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadData();

        }

        public void loadData()
        {
            var dssv = qlsv.SINHVIENs.Select(x => new
            {
                x.MaSV,
                x.HoTen,
                x.LOP.TenLop,
                x.LOP.KHOA.TenKhoa
            }).ToList();

            dataGridViewTTSV.DataSource = dssv;


            cbLop.DisplayMember = "TenLop";//hiển thị cột TenLop lên Combo box
            cbLop.ValueMember = "MaLop"; // Khi hiển thị rồi mà người dùng chọn thì nó lấy cột MaLop
            cbLop.DataSource = qlsv.LOPs.ToList();//hiển thị dữ liệu từ DB lên combo

            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.DataSource = qlsv.KHOAs.ToList();


            cbMonHoc.DisplayMember = "TenMH";
            cbMonHoc.ValueMember = "MaMH";
            cbMonHoc.DataSource = qlsv.MONHOCs.ToList();
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maKhoa = Convert.ToInt32(cbKhoa.SelectedValue.ToString());

            var dssv = qlsv.SINHVIENs.Where(x => x.LOP.KHOA.MaKhoa == maKhoa).Select(x => new
            {
                x.MaSV,
                x.HoTen,
                x.LOP.TenLop,
                x.LOP.KHOA.TenKhoa
            }).ToList();

            dataGridViewTTSV.DataSource = dssv;

            var dslop = qlsv.LOPs.Where(x => x.KHOA.MaKhoa == maKhoa).Select(x => new
            {
                x.TenLop,
                x.MaLop
            }).ToList();

            cbLop.DataSource = dslop;

        }

        private void cbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            int malop = Convert.ToInt32(cbLop.SelectedValue.ToString() );
            var dssv = qlsv.SINHVIENs.Where(t => t.LOP.MaLop == malop).Select(t => new
            {
                t.MaSV,
                t.HoTen,
                t.LOP.TenLop,
                t.LOP.KHOA.TenKhoa
            }).ToList();

            dataGridViewTTSV.DataSource = dssv;
        }

        

        private void dataGridViewTTSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtMaSinhVien.Text = dataGridViewTTSV.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTen.Text = dataGridViewTTSV.Rows[e.RowIndex].Cells[1].Value.ToString();
            loadDataDiemSV();

        }

        private void dataGridViewDiemSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mmh = Convert.ToInt32(dataGridViewDiemSV.Rows[e.RowIndex].Cells[0].Value.ToString());
            cbMonHoc.Text = dataGridViewDiemSV.Rows[e.RowIndex].Cells[1].Value.ToString();
           txtDiemQT.Text = dataGridViewDiemSV.Rows[e.RowIndex].Cells["DiemQuaTrinh"].Value.ToString();
           txtDiemGK.Text = dataGridViewDiemSV.Rows[e.RowIndex].Cells["DiemGiuaKy"].Value.ToString();
           txtDiemCK.Text = dataGridViewDiemSV.Rows[e.RowIndex].Cells["DiemCuoiKy"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int masv = Convert.ToInt32(txtMaSinhVien.Text);
            int mamh = Convert.ToInt32(cbMonHoc.SelectedValue.ToString());

            int DQT = Convert.ToInt32(txtDiemQT.Text);
            int DGK = Convert.ToInt32(txtDiemGK.Text);
            int DCK = Convert.ToInt32(txtDiemCK.Text);

            DIEM diem = new DIEM()
            {
                MaSV = masv,
                MaMH = mamh,
                DiemQuaTrinh = DQT,
                DiemGiuaKy = DGK,
                DiemCuoiKy = DCK,
            };

            qlsv.DIEMs.Add(diem);
            qlsv.SaveChanges();

            loadDataDiemSV();
        }

        private void loadDataDiemSV()
        {
            int maSV = Convert.ToInt32(txtMaSinhVien.Text);
            var dsdiem = qlsv.DIEMs.Where(x => x.MaSV == maSV).Select(x => new
            {
                x.MONHOC.MaMH,
                x.MONHOC.TenMH,

                x.DiemQuaTrinh,
                x.DiemGiuaKy,
                x.DiemCuoiKy
            }).ToList();

            dataGridViewDiemSV.DataSource = dsdiem;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSV = Convert.ToInt32(txtMaSinhVien.Text);

            DIEM dsv = qlsv.DIEMs.Where(h => h.SINHVIEN.MaSV == maSV && h.MONHOC.MaMH == mmh).First();

            dsv.DiemQuaTrinh = Convert.ToInt32(txtDiemQT.Text);
            dsv.DiemGiuaKy = Convert.ToInt32(txtDiemGK.Text);
            dsv.DiemCuoiKy = Convert.ToInt32(txtDiemCK.Text);

            qlsv.SaveChanges();

            loadDataDiemSV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {
                int maSV = Convert.ToInt32(txtMaSinhVien.Text);
                int maMH = Convert.ToInt32(cbMonHoc.SelectedValue.ToString());
                var diem = qlsv.DIEMs.Where(h => h.SINHVIEN.MaSV == maSV && h.MONHOC.MaMH == maMH).First();

                qlsv.DIEMs.Remove(diem);

                qlsv.SaveChanges();

                loadDataDiemSV();
            }



           
            
        }


        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTim.Text))
            {
                loadData();
            } else
            {
                String tenSV = txtTim.Text;

                dataGridViewTTSV.DataSource = qlsv.SINHVIENs.Where(h => h.HoTen.Contains(tenSV)).Select(h => new
                {
                    h.MaSV,
                    h.HoTen,
                    h.LOP.TenLop,
                    h.LOP.KHOA.TenKhoa

                }).ToList();
            }
        }

        private void cbKhoa_DropDown(object sender, EventArgs e)
        {

        }

        private void cbLop_DropDown(object sender, EventArgs e)
        {

        }

        private void dataGridViewDiemSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
