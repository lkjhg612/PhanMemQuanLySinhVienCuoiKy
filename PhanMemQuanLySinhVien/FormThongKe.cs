using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanMemQuanLySinhVien
{
    public partial class FormThongKe : Form
    {
        public List<DIEM> hs = new List<DIEM>();
        public FormThongKe()
        {
            InitializeComponent();
        }
        QUANLYSINHVIEN db = new QUANLYSINHVIEN();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
             dataGridView1.DataSource = null;
             getListHocSinh(comboBox1.Text);

        }

        private void getListHocSinh(String hocLuc)
        {


            if (hocLuc.Equals("Giỏi"))
            {
              var  ds = db.DIEMs.Where( x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 8.5).Select(
             x => new
             {
                x.SINHVIEN.HoTen,
                x.SINHVIEN.LOP.TenLop,
                x.MONHOC.TenMH,
                x.DiemQuaTrinh,
                x.DiemGiuaKy,
                x.DiemCuoiKy
             }
                 
                  ).ToList();
                dataGridView1.DataSource = ds;

            } else if (hocLuc.Equals("Khá"))
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 6.5 && (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 8.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }

                    ).ToList();
                dataGridView1.DataSource = ds;
            }
            else if (hocLuc.Equals("Trung Bình"))
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 4.5 && (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 6.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }

                    ).ToList();
                dataGridView1.DataSource = ds;
            }
            else 
            {
                var ds = db.DIEMs.Where(x =>  (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 4.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }
                    ).ToList();
                dataGridView1.DataSource = ds;
            }
        }


      /*  List<DIEM> lochstheoloai(String loai)
        {
            var ds = db.DIEMs.ToList();


            if (loai.Equals("Giỏi"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)( ((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) /2 )*0.3 +  (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 8.5)
                    {
                        hs.Add(lochs);
                       
                    }
                }
            }else if (loai.Equals("Khá"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)( ( (lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2 ) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 6.5 && tinhdiem < 8.5)
                    {
                        hs.Add(lochs);
                        
                    }
                }
            }else if (loai.Equals("Trung Bình"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)( ((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2 )* 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 4.5 && tinhdiem < 6.5)
                    {
                        hs.Add(lochs);
                        
                    }
                }
            }else if (loai.Equals("Học Lại"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)(((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem < 4.5 )
                    {
                        hs.Add(lochs);                       
                    }
                }
            }
            return hs;
        }
*/


        void Loadata()
        {
            var ds = db.DIEMs.Select(x => new
         {
             x.SINHVIEN.HoTen,
             x.SINHVIEN.LOP.TenLop,           
             x.MONHOC.TenMH,
             x.DiemQuaTrinh,
             x.DiemGiuaKy,
             x.DiemCuoiKy
         }).ToList();
            dataGridView1.DataSource = ds;          
        }
        

        private void FormThongKe_Load(object sender, EventArgs e)
        {

            var ds = db.DIEMs.Select(x => new { x.DiemCuoiKy, x.DiemGiuaKy, x.DiemQuaTrinh, x.MONHOC.TenMH }).ToList();
            Loadata();

        }
    
        

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //Loadata();
 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getListDiemHocSinh(comboBox2.Text);
           
            
        }
      /*  List<DIEM> lochstheodiem(String diem)
        {
            var ds = db.DIEMs.ToList();
            if (diem.Equals(">= 8.5"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)(((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 8.5)
                    {
                        hs.Add(lochs);

                    }
                }
            }
            else if (diem.Equals("6.5<= Và <8"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)(((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 6.5 && tinhdiem < 8.5)
                    {
                        hs.Add(lochs);

                    }
                }
            }            
            else if (diem.Equals("4.5<= Và <6.5"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)(((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem >= 4.5 && tinhdiem < 6.5)
                    {
                        hs.Add(lochs);

                    }
                }
            }
            else if (diem.Equals("<4.5"))
            {
                foreach (var lochs in ds)
                {
                    float tinhdiem = (float)(((lochs.DiemQuaTrinh + lochs.DiemGiuaKy) / 2) * 0.3 + (lochs.DiemCuoiKy) * 0.7);
                    if (tinhdiem < 4.5)
                    {
                        hs.Add(lochs);
                    }
                }
            }
            return hs;
        }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Loadata();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtten.Text = dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
            txttenlop.Text = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value.ToString();
            txtTenMH.Text = dataGridView1.Rows[e.RowIndex].Cells["TenMH"].Value.ToString();
            txtdqt.Text = dataGridView1.Rows[e.RowIndex].Cells["DiemQuaTrinh"].Value.ToString();
            txtdiemgk.Text = dataGridView1.Rows[e.RowIndex].Cells["DiemGiuaKy"].Value.ToString();
            txtdiemck.Text = dataGridView1.Rows[e.RowIndex].Cells["DiemCuoiKy"].Value.ToString();
            double diemqt = Convert.ToDouble(txtdqt.Text);
            double diemgk = Convert.ToDouble(txtdiemgk.Text);
            double diemck = Convert.ToDouble(txtdiemck.Text);
            double kq = ((diemqt + diemgk) / 2) * 0.3 + (diemck) * 0.7;
            txtdiemtb.Text = kq.ToString();
            if (kq >= 8.5)
            {
                txtxl.Text = "Giỏi";             
            }else if(kq >= 6.5 && kq < 8.5)
            {
                txtxl.Text = "Khá";
            }else if (kq >= 4.5 && kq < 6.5)
            {
                txtxl.Text = "Trung Bình";
            }
            else
            {
                txtxl.Text = "Học Lại";
             
            }


        }

        private void getListDiemHocSinh(String diem)
        {


            if (diem.Equals(">= 8.5"))
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 8.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }

                    ).ToList();
                dataGridView1.DataSource = ds;

            }
            else if (diem.Equals("6.5<= Và <8"))
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 6.5 && (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 8.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }

                    ).ToList();
                dataGridView1.DataSource = ds;
            }
            else if (diem.Equals("4.5<= Và <6.5"))
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) >= 4.5 && (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 6.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }

                    ).ToList();
                dataGridView1.DataSource = ds;
            }
            else
            {
                var ds = db.DIEMs.Where(x => (((x.DiemQuaTrinh + x.DiemGiuaKy) / 2) * 0.3 + (x.DiemCuoiKy * 0.7)) <= 4.5).Select(
               x => new
               {
                   x.SINHVIEN.HoTen,
                   x.SINHVIEN.LOP.TenLop,
                   x.MONHOC.TenMH,
                   x.DiemQuaTrinh,
                   x.DiemGiuaKy,
                   x.DiemCuoiKy
               }
                    ).ToList();
                dataGridView1.DataSource = ds;
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
             

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Loadata();
        }
    }
}
