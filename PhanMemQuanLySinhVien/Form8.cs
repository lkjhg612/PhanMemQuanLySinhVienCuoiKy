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
    public partial class Form8 : Form
    {
        QUANLYSINHVIEN qlsv = new QUANLYSINHVIEN();
        NGUOIDUNG user;
       
        public Form8(NGUOIDUNG nd)
        {
            InitializeComponent();
            user = nd;
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            txtMaSinhVien.Text = user.SINHVIEN.MaSV.ToString();
            txtHoTen.Text = user.SINHVIEN.HoTen;
            txtLop.Text = user.SINHVIEN.LOP.TenLop;
            dateTimeNTNS.Value = Convert.ToDateTime( user.SINHVIEN.NTNS);
            txtDiaChi.Text = user.SINHVIEN.DiaChi;
           if (user.SINHVIEN.GioiTinh.Equals("Nam"))
            {
                rbtnNam.Checked = true;
            } else
            {
                rbtnNu.Checked = true;
            }

           var listDiem = qlsv.DIEMs.Where(x => x.MaSV == user.MaSV).Select(x => new
           {
               x.MONHOC.MaMH,
               x.MONHOC.TenMH,
               x.DiemQuaTrinh,
               x.DiemGiuaKy,
               x.DiemCuoiKy,
               DiemTB = x.DiemGiuaKy * 0.3 + x.DiemCuoiKy * 0.7
           }).ToList();

            dataGridViewDiemSinhVien.DataSource = listDiem;

            //for (int i=0; i < soLuong; i++)
            //{
            //    double diem = Convert.ToInt32(listDiem[i].DiemTB);
            //    tong = tong + diem;
            //}

            double tong = 0;
            int soLuong = listDiem.Count();
            foreach (var d in listDiem)
            {
                tong += Convert.ToDouble(d.DiemTB);
            }

            txtDiemTrungBinh.Text =(Convert.ToDouble(tong/soLuong)).ToString();

            double diemtb = Convert.ToDouble(txtDiemTrungBinh.Text);
             txtXepLoai.Text =  xepLoai(diemtb);
            
        }

        private String xepLoai(double diemtb)
        {
            String xeploai = null;
            if (diemtb < 4)
            {
                xeploai = "Yếu";
            }
            else if (diemtb >= 4 && diemtb < 6)
            {
                xeploai = "Trung bình";
            }
            else if (diemtb >= 6 && diemtb < 8)
            {
                xeploai = "Khá";
            }
            else
            {
                xeploai = "Giỏi";
            }
            return xeploai;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormXemTKB fx = new FormXemTKB(user);
            fx.ShowDialog();
            this.Show();
        }
    }
}
