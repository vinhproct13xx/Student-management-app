using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLHS
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap busDN = new BUS.BUS_DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length == 0)
            {
                lbThongBao.Text = "Vui lòng nhập tài khoản!";
                lbThongBao.Visible = true;
            }
            else if (txtTaiKhoan.Text.Length > 20)
            {
                lbThongBao.Text = "Tài khoản gồm 20 kí tự trở xuống!";
                lbThongBao.Visible = true;
            }
            else if (txtMatKhau.Text.Length == 0)
            {
                lbThongBao.Text = "Vui lòng nhập mật khẩu!";
                lbThongBao.Visible = true;
            }
            else if (txtMatKhau.Text.Length > 20)
            {
                lbThongBao.Text = "Mật khẩu gồm 20 kí tự trở xuống!";
                lbThongBao.Visible = true;
            }
            else
            {
                DTO_DangNhap dn = new DTO_DangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                if (busDN.checkDangNhap(dn)==true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thống Báo");
                    frmGiaoDienChinh f = new frmGiaoDienChinh();
                    f.ShowDialog();
                    lbThongBao.Visible = false;
                }
                else
                {
                    lbThongBao.Text="Sai tên tài khoản hoặc mặt khẩu!";
                    lbThongBao.Visible = true;
                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
