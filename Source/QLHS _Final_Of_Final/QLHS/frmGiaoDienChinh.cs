using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI;

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
            string a = frmDangNhap.LuuThongTin.taikhoan;
            if(a=="admin")
            {
                tsHoSo.Enabled = true;
                tsLop.Enabled = true;
                tsDiem.Enabled = true;
                tsBaoCao.Enabled = true;
                tsQuyDinh.Enabled = true;
            }
            else if(a == "admin2")
            {
                tsHoSo.Enabled = true;
                tsLop.Enabled = true;
                tsDiem.Enabled = true;
                tsBaoCao.Enabled = true;
                tsQuyDinh.Enabled = false;
            }
            else
            {
                tsHoSo.Enabled = true;
                tsLop.Enabled = false;
                tsDiem.Enabled = false;
                tsBaoCao.Enabled = false;
                tsQuyDinh.Enabled = false;
                tsTiepNhanHoSo.Enabled = false;
            }
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
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void tsThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsDangXuat_Click(object sender, EventArgs e)
        {
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

        private void tsTiepNhanHoSo_Click(object sender, EventArgs e)
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

        private void tsTraCuuHoSo_Click(object sender, EventArgs e)
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


        private void tsNhapDiem_Click_1(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmNhapDiem"))
            {
                frmNhapDiem frm = new frmNhapDiem();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmNhapDiem");
        }

        private void tsTBM_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmDTB"))
            {
                frmDTB frm = new frmDTB();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmDTB");
        }

        private void tsTBC_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmDTBChung"))
            {
                frmDTBChung frm = new frmDTBChung();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmDTBChung");
        }

        private void tsChuyenLop_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmChuyenLop"))
            {
                frmChuyenLop frm = new frmChuyenLop();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmChuyenLop");
        }

        private void tsTaoLop_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("TaoLop"))
            {
                TaoLop frm = new TaoLop();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("TaoLop");
        }

        private void tsTongKetMon_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmTongKet"))
            {
                frmTongKet frm = new frmTongKet();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmTongKet");
        }

        private void tsTongKetChung_Click(object sender, EventArgs e)
        {
            if (!CheckExistFrom("frmTongKetChung"))
            {
                frmTongKetChung frm = new frmTongKetChung();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmTongKetChung");
        }
    }
}
