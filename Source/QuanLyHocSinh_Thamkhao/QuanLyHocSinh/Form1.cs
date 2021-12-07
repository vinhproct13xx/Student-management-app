using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTiepNhanHS_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmTiepNhanHocSinh();
            f.ShowDialog();
        }

        private void btnLapDanhSachLop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new frmChuyenLop();
            f2.ShowDialog();
        }

        private void btnTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmTraCuuHocSinh();
            f.ShowDialog();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmNhapDiem();
            f.ShowDialog();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmBaoCaoHocKy();
            f.ShowDialog();
        }
    }
}
