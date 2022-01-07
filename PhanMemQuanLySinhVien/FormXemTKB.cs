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
    public partial class FormXemTKB : Form
    {
        QUANLYSINHVIEN db = new QUANLYSINHVIEN();
        public FormXemTKB(NGUOIDUNG nguoidung)
        {
            InitializeComponent();
            loaddata(nguoidung);
        }
        public void loaddata(NGUOIDUNG nguoidung) {
            try
            {
                List<CHITIETTHOIKHOABIEU> lstct = db.CHITIETTHOIKHOABIEUx.Where(n=>n.THOIKHOABIEU.IdLop == nguoidung.SINHVIEN.MaLop ).ToList();
                
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lstct.Select(n => new
                {
                    n.THU.TenThu,
                    n.Buoi.TenBuoi,
                    n.MONHOC.TenMH,
                    n.THOIKHOABIEU.NgayBatDau,
                    n.THOIKHOABIEU.NgayKetThuc,
                    n.THOIKHOABIEU.LOP.TenLop,
                    n.HoVaTenGV
                }).ToList();
                List<LOP> lop = db.LOPs.ToList();
              
            }
            catch (Exception) { }
        }
      
        
    }
}
