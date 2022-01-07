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
        QUANLYSINHVIEN db = new QUANLYSINHVIEN();
        public FormTKB()
        {
            InitializeComponent();
        }

        private void FormTKB_Load(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
