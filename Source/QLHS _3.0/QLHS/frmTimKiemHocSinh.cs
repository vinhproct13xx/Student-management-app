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
    public partial class frmTimKiemHocSinh : Form
    {
        BUS_TimKiemHocSinh busTK = new BUS_TimKiemHocSinh();
        public frmTimKiemHocSinh()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public bool IsNumber(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]) == false)
                    return false;
            }
            return true;
        }
        private void frmTimKiemHocSinh_Load(object sender, EventArgs e)
        {
            dgvTimKiem.DataSource = busTK.getHocSinh();
        }

        private void btnTimKiemHocSinh_Click(object sender, EventArgs e)
        {
            string dmy = dtpTimKiemHocSinh.Value.ToString("MM/dd/yyyy");
            string a="";
            if (cboTimKiemHocSinh.Text == "Mã Học Sinh")
            {
                a = "MAHS";
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên")
            {
                a = "HOTEN";
            }
            else if (cboTimKiemHocSinh.Text == "Địa Chỉ")
            {
                a = "DIACHI";
            }
            else if (cboTimKiemHocSinh.Text == "Ngày Sinh")
            {
                a = "NGAYSINH";
            }
            else if (cboTimKiemHocSinh.Text == "Tháng Sinh")
            {
                a = "THANGSINH";
            }
            else if (cboTimKiemHocSinh.Text == "Năm Sinh")
            {
                a = "NAMSINH";
            }
            else if (cboTimKiemHocSinh.Text == "Giới Tính")
            {
                a = "GIOITINH";
            }
            else if (cboTimKiemHocSinh.Text == "Tôn Giáo")
            {
                a = "TONGIAO";
            }
            else if (cboTimKiemHocSinh.Text == "Dân Tộc")
            {
                a = "DANTOC";
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên Cha")
            {
                a = "HOTENCHA";
            }
            else if (cboTimKiemHocSinh.Text == "Nghề Nghiệp Cha")
            {
                a = "NGHENGHIEPCHA";
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên Mẹ")
            {
                a = "HOTENME";
            }
            else if (cboTimKiemHocSinh.Text == "Nghề Nghiệp Mẹ")
            {
                a = "NGHENGHIEPME";
            }
            else if (cboTimKiemHocSinh.Text == "Ngày Tháng Năm Sinh")
            {
                a = "NGAYTHANGNAMSINH";
            }

            if (a == "MAHS")
            {
                if (txtTimKiemHocSinh.Text.Length != 0)
                {
                    if (IsNumber(txtTimKiemHocSinh.Text))
                    {
                        DTO_TimKiemHocSinh tk1 = new DTO_TimKiemHocSinh(a, txtTimKiemHocSinh.Text);
                        if (busTK.checkTimKiem(tk1))
                        {
                            dgvTimKiem.DataSource = busTK.TimKiemHocSinh(tk1);
                        }
                        else MessageBox.Show("Không tìm thấy từ khóa cần tìm", "Thông báo");
                        lblThongBao.Visible = false;
                    }
                    else
                    {
                        lblThongBao.Visible = true;
                        lblThongBao.Text = "Từ khóa cần nhập là con số!!";
                    }
                }
                else
                {
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Vui lòng nhập từ khóa cần tìm!!";
                }
            }
            else if (a == "NGAYTHANGNAMSINH")
            {

                DTO_TimKiemHocSinh tk1 = new DTO_TimKiemHocSinh(a, dmy);
                if (busTK.checkTimKiem(tk1))
                {
                    dgvTimKiem.DataSource = busTK.TimKiemHocSinh(tk1);
                }
                else MessageBox.Show("Không tìm thấy từ khóa cần tìm", "Thông báo");
                lblThongBao.Visible = false;
            }
            else
            {
                if (txtTimKiemHocSinh.Text.Length != 0)
                {
                    DTO_TimKiemHocSinh tk1 = new DTO_TimKiemHocSinh(a, txtTimKiemHocSinh.Text);
                    if (busTK.checkTimKiem(tk1))
                    {
                        dgvTimKiem.DataSource = busTK.TimKiemHocSinh(tk1);
                    }
                    else MessageBox.Show("Không tìm thấy từ khóa cần tìm", "Thông báo");
                    lblThongBao.Visible = false;
                }
                else
                {
                    lblThongBao.Visible = true;
                    lblThongBao.Text = "Vui lòng nhập từ khóa cần tìm!!";
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn quay lại hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            dgvTimKiem.DataSource = busTK.getHocSinh();
        }

        private void cboTimKiemHocSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTimKiemHocSinh.Text == "Mã Học Sinh")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Địa Chỉ")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Ngày Sinh")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Tháng Sinh")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Năm Sinh")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Giới Tính")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Tôn Giáo")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Dân Tộc")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên Cha")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Nghề Nghiệp Cha")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Họ Tên Mẹ")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;

            }
            else if (cboTimKiemHocSinh.Text == "Nghề Nghiệp Mẹ")
            {
                txtTimKiemHocSinh.Enabled = true;
                dtpTimKiemHocSinh.Enabled = false;
            }
            else if (cboTimKiemHocSinh.Text == "Ngày Tháng Năm Sinh")
            {
                txtTimKiemHocSinh.Enabled = false;
                dtpTimKiemHocSinh.Enabled = true;
            }
        }
    }
}
