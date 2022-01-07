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
    public partial class FormTKB : Form
    {
        int a;
        QUANLYSINHVIEN db = new QUANLYSINHVIEN();
        public FormTKB()
        {
            InitializeComponent();
            loaddata();
            
        }
        
        private void btn_ThemTKB_Click(object sender, EventArgs e)
        {
            int idLop = Convert.ToInt32(cbxLop.SelectedValue);
            THOIKHOABIEU tkb = db.THOIKHOABIEUx.FirstOrDefault(n => n.IdLop == idLop);
            if (tkb == null)
            {
                tkb = new THOIKHOABIEU();
                tkb.IdKhoa = int.Parse(cbxKhoa.SelectedValue.ToString());
                tkb.IdLop = int.Parse(cbxLop.SelectedValue.ToString());
                tkb.NgayBatDau = datefirstTKB.Value;
                tkb.NgayKetThuc = datelasttkb.Value;
                db.THOIKHOABIEUx.Add(tkb);
            }
            CHITIETTHOIKHOABIEU cttkb=tkb.CHITIETTHOIKHOABIEUx.FirstOrDefault(n => n.THU.IdThu == int.Parse(cbxThu.SelectedValue.ToString()) && n.Buoi.IdBuoi == int.Parse(cbxBuoi.SelectedValue.ToString()));
            if (cttkb == null)
            {
                cttkb = new CHITIETTHOIKHOABIEU();
                cttkb.IdTKB = tkb.IdTKB;
                cttkb.IdThu = int.Parse(cbxThu.SelectedValue.ToString());
                cttkb.IdBuoi = int.Parse(cbxBuoi.SelectedValue.ToString());
                cttkb.IdMonHoc = int.Parse(cbxMH.SelectedValue.ToString());
                cttkb.HoVaTenGV = txtTenGV.Text;
                db.CHITIETTHOIKHOABIEUx.Add(cttkb);
                db.SaveChanges();
            }
            else {
                MessageBox.Show("Có thời khóa biểu này rồi");
            }
           gvtkb.DataSource = tkb.CHITIETTHOIKHOABIEUx.ToList().Select(n => new
           {
               n.THU.TenThu,
               n.Buoi.TenBuoi,
               n.MONHOC.TenMH,
               n.THOIKHOABIEU.NgayBatDau,
               n.THOIKHOABIEU.NgayKetThuc,
               n.THOIKHOABIEU.LOP.TenLop,
               n.HoVaTenGV
           }).ToList(); 
        }
        public void loaddata() {

            List<KHOA> lstKhoa = db.KHOAs.ToList();
            List<LOP> lstLop = db.LOPs.ToList();
            List<MONHOC> lstMH = db.MONHOCs.ToList();
            List<THU> lstThu = db.THUs.ToList();
            List<Buoi> lstBuoi = db.Buois.ToList();
            List<CHITIETTHOIKHOABIEU> lstCTTKB = db.CHITIETTHOIKHOABIEUx.OrderBy(n=>n.THOIKHOABIEU.KHOA.MaKhoa).ThenBy(n => n.THOIKHOABIEU.LOP.MaLop).ThenBy(n => n.THU.IdThu).ThenBy(n => n.Buoi.IdBuoi).ToList();
            gvtkb.DataSource = null;
            gvtkb.DataSource = lstCTTKB.Select(n => new
            {
                n.THU.TenThu, n.Buoi.TenBuoi, n.MONHOC.TenMH, n.THOIKHOABIEU.NgayBatDau,
                n.THOIKHOABIEU.NgayKetThuc, n.THOIKHOABIEU.LOP.TenLop, n.HoVaTenGV
            }).ToList();
            cbxKhoa.DataSource = lstKhoa.Select(n => new {
                n.MaKhoa, n.TenKhoa
            }).ToList();
            cbxKhoa.DisplayMember = "TenKhoa";
            cbxKhoa.ValueMember = "MaKhoa";
            cbxLop.DataSource = lstLop;
            cbxLop.DisplayMember = "TenLop";
            cbxLop.ValueMember = "MaLop";
            cbxMH.DataSource = lstMH;
            cbxMH.DisplayMember = "TenMH";
            cbxMH.ValueMember = "MaMH";
            cbxThu.DataSource = lstThu;
            cbxThu.DisplayMember = "TenThu";
            cbxThu.ValueMember = "IdThu";
            cbxBuoi.DataSource = lstBuoi;
            cbxBuoi.DisplayMember = "TenBuoi";
            cbxBuoi.ValueMember = "IdBuoi";
            

        }

       

        private void btn_SuaTKB_Click(object sender, EventArgs e)
        {
            int idLop = Convert.ToInt32(cbxLop.SelectedValue);
            THOIKHOABIEU tkb = db.THOIKHOABIEUx.FirstOrDefault(n => n.IdLop == idLop);
            CHITIETTHOIKHOABIEU cttkb = tkb.CHITIETTHOIKHOABIEUx.FirstOrDefault(n => n.THU.IdThu == int.Parse(cbxThu.SelectedValue.ToString()) && n.Buoi.IdBuoi == int.Parse(cbxBuoi.SelectedValue.ToString()) );
            cttkb.IdThu = int.Parse(cbxThu.SelectedValue.ToString());
            cttkb.IdBuoi = int.Parse(cbxBuoi.SelectedValue.ToString());
            cttkb.IdMonHoc = int.Parse(cbxMH.SelectedValue.ToString());
            cttkb.HoVaTenGV = txtTenGV.Text;
            db.SaveChanges();
            gvtkb.DataSource = tkb.CHITIETTHOIKHOABIEUx.ToList().Select(n => new
            {
                n.THU.TenThu,
                n.Buoi.TenBuoi,
                n.MONHOC.TenMH,
                n.THOIKHOABIEU.NgayBatDau,
                n.THOIKHOABIEU.NgayKetThuc,
                n.THOIKHOABIEU.LOP.TenLop,
                n.HoVaTenGV
            }).ToList(); ;
        }

        private void gvtkb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string ten = gvtkb.Rows[e.RowIndex].Cells[0].Value.ToString();
                int idThu = db.THUs.FirstOrDefault(n => n.TenThu.Contains(ten)).IdThu;
                string tenbuoi = gvtkb.Rows[e.RowIndex].Cells[1].Value.ToString();
                int idBuoi = db.Buois.FirstOrDefault(n => n.TenBuoi.Contains(tenbuoi)).IdBuoi;
                string tenLop = gvtkb.Rows[e.RowIndex].Cells[5].Value.ToString();
                int idLop = db.LOPs.FirstOrDefault(n => n.TenLop.Contains(tenLop)).MaLop;
                CHITIETTHOIKHOABIEU cttkb = db.CHITIETTHOIKHOABIEUx.FirstOrDefault(n => n.IdThu == idThu && n.IdBuoi == idBuoi && n.THOIKHOABIEU.IdLop == idLop);
                datefirstTKB.Value = cttkb.THOIKHOABIEU.NgayBatDau.Value;
                datelasttkb.Value = cttkb.THOIKHOABIEU.NgayKetThuc.Value;
                cbxKhoa.SelectedValue = cttkb.THOIKHOABIEU.IdKhoa;
                cbxLop.SelectedValue = cttkb.THOIKHOABIEU.IdLop;
                a = Convert.ToInt32(cttkb.THOIKHOABIEU.IdLop);
                cbxMH.SelectedValue = cttkb.IdMonHoc;
                cbxThu.SelectedValue = cttkb.IdThu;
                cbxBuoi.SelectedValue = cttkb.IdBuoi;
                txtTenGV.Text = cttkb.HoVaTenGV;
            }
            catch (Exception) { }
        }

        private void cbxKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int MaKhoa = int.Parse(cbxKhoa.SelectedValue.ToString());
                List<CHITIETTHOIKHOABIEU> cttkb = db.CHITIETTHOIKHOABIEUx.Where(n => n.THOIKHOABIEU.IdKhoa == MaKhoa).OrderBy(n => n.THOIKHOABIEU.KHOA.MaKhoa).ThenBy(n => n.THOIKHOABIEU.LOP.MaLop).ThenBy(n => n.THU.IdThu).ThenBy(n => n.Buoi.IdBuoi).ToList(); ;
                gvtkb.DataSource = cttkb.Select(n => new
                {
                    n.THU.TenThu,
                    n.Buoi.TenBuoi,
                    n.MONHOC.TenMH,
                    n.THOIKHOABIEU.NgayBatDau,
                    n.THOIKHOABIEU.NgayKetThuc,
                    n.THOIKHOABIEU.LOP.TenLop,
                    n.HoVaTenGV
                }).ToList();
            }
            catch (Exception) { }

        }

        private void cbxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                int MaLop = int.Parse(cbxLop.SelectedValue.ToString());
                LOP lop = db.LOPs.FirstOrDefault(n => n.MaLop == MaLop);
                cbxKhoa.SelectedValue = lop.MaKhoa;
                List<CHITIETTHOIKHOABIEU> cttkb = db.CHITIETTHOIKHOABIEUx.Where(n => n.THOIKHOABIEU.IdLop == MaLop).OrderBy(n => n.THOIKHOABIEU.KHOA.MaKhoa).ThenBy(n => n.THOIKHOABIEU.LOP.MaLop).ThenBy(n => n.THU.IdThu).ThenBy(n => n.Buoi.IdBuoi).ToList();
                gvtkb.DataSource = cttkb.Select(n => new
                {
                    n.THU.TenThu,
                    n.Buoi.TenBuoi,
                    n.MONHOC.TenMH,
                    n.THOIKHOABIEU.NgayBatDau,
                    n.THOIKHOABIEU.NgayKetThuc,
                    n.THOIKHOABIEU.LOP.TenLop,
                    n.HoVaTenGV
                }).ToList();
            }
            catch (Exception) { }
        }

        private void btn_XoaTKB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Thông báo!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                int idLop = Convert.ToInt32(cbxLop.SelectedValue);
                THOIKHOABIEU tkb = db.THOIKHOABIEUx.FirstOrDefault(n => n.IdLop == idLop);
                if (tkb == null)
                {
                    MessageBox.Show("Không có thời khóa biểu này");
                }
                CHITIETTHOIKHOABIEU cttkb = tkb.CHITIETTHOIKHOABIEUx.FirstOrDefault(n => n.THU.IdThu == int.Parse(cbxThu.SelectedValue.ToString()) && n.Buoi.IdBuoi == int.Parse(cbxBuoi.SelectedValue.ToString()));
                if (cttkb == null)
                {
                    MessageBox.Show("Không có thời khóa biểu này");
                }
                else
                {

                    CHITIETTHOIKHOABIEU cttkbxoa = db.CHITIETTHOIKHOABIEUx.Find(cttkb.IdCTTKB);
                    db.CHITIETTHOIKHOABIEUx.Remove(cttkbxoa);
                    db.SaveChanges();
                }
                loaddata();
            }
        
        }
    }
}
