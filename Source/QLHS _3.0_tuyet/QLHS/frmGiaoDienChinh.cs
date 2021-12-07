using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class frmGiaoDienChinh : Form
    {
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {

        }
        private bool CheckExistFrom(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

       
        private void tsTiepNhanHocSinh_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmTiepNhanHocSinh"))
            {
                frmTiepNhanHocSinh frm = new frmTiepNhanHocSinh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmTiepNhanHocSinh");
        }

        private void tsTraCuuHocSinh_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmTimKiemHocSinh"))
            {
                frmTimKiemHocSinh frm = new frmTimKiemHocSinh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmTimKiemHocSinh");
        }


        private void tsThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Close();
        }

        private void tsQuyDinh_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("GUI.frmThayDoiQuyDinh"))
            {
                GUI.frmThayDoiQuyDinh frm = new GUI.frmThayDoiQuyDinh();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("GUI.frmThayDoiQuyDinh");
        }

        private void tsChuyenLop_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("GUI.frmChuyenLop"))
            {
                GUI.frmChuyenLop frm = new GUI.frmChuyenLop();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("GUI.frmChuyenLop");
        }

        private void tsTaoLop_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("GUI.TaoLop"))
            {
                GUI.TaoLop frm = new GUI.TaoLop();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("GUI.TaoLop");
        }

        private void tsNhapDiem_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("GUI.frmNhapDiem"))
            {
                GUI.frmNhapDiem frm = new GUI.frmNhapDiem();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("GUI.frmNhapDiem");
        }
    }
}
