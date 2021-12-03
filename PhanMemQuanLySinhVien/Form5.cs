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
    public partial class Form5 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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



            //var dsdiem = qlsv.DIEMs.Select(x => new
            //{
            //    x.MONHOC.MaMH,
            //    x.MONHOC.TenMH,
            //    x.DiemQuaTrinh,
            //    x.DiemGiuaKy,
            //    x.DiemCuoiKy

            //}).ToList();

            //dataGridViewDiemSV.DataSource = dsdiem;
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
            int malop = Convert.ToInt32( cbLop.SelectedValue.ToString() );
            var dssv = qlsv.SINHVIENs.Where(t => t.LOP.MaLop == malop).Select(t => new
            {
                t.MaSV,
                t.HoTen,
                t.LOP.TenLop,
                t.LOP.KHOA.TenKhoa
            }).ToList();

            dataGridViewTTSV.DataSource = dssv;
        }
    }
}
