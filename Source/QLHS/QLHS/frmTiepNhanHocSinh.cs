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
    public partial class frmTiepNhanHocSinh : Form
    {
        BUS_TiepNhanHocSinh busHS = new BUS_TiepNhanHocSinh();
        public frmTiepNhanHocSinh()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn quay lại hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }
        private void frmTiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = busHS.getHocSinh();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
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
        private void btnThemVaoDanhSach_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            lblThongBao.Visible = true;
            int year = DateTime.Now.Year;
            int dtp = dtpNgaySinh.Value.Year;
            //if (IsNumber(txtMaHocSinh.Text) == false || (txtMaHocSinh.Text.Length != 4))
            //{
            //    lblThongBao.Text ="Mã học sinh phải là 4 con số!!";
            //    lblThongBao.Visible = true;
            //}
            if (txtHoTenHocSinh.Text.Length == 0 || txtHoTenHocSinh.Text.Length > 40)
            {
                lblThongBao.Text = "Họ và tên phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (txtDiaChi.Text.Length == 0 || txtDiaChi.Text.Length > 40)
            {
                lblThongBao.Text = "Địa chỉ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (dtp < 1999 || dtp > 2003)
            {
                lblThongBao.Text = "Năm sinh phải từ năm 1999 -> 2003!!";
                lblThongBao.Visible = true;
            }
            else if (cboGioiTinh.Text.Length == 0)
            {
                lblThongBao.Text = "Vui lòng chọn giới tính!!";
                lblThongBao.Visible = true;
            }
            else if (cboTonGiao.Text.Length == 0)
            {
                lblThongBao.Text = "Vui lòng chọn tôn giáo!!";
                lblThongBao.Visible = true;
            }
            else if (cboDanToc.Text.Length == 0)
            {
                lblThongBao.Text = "Vui lòng chọn dân tộc!!";
                lblThongBao.Visible = true;
            }
            else if (txtHoTenCha.Text.Length == 0 || txtHoTenCha.Text.Length > 40)
            {
                lblThongBao.Text = "Họ tên cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (txtNgheNghiepCha.Text.Length == 0 || txtNgheNghiepCha.Text.Length>40)
            {
                lblThongBao.Text = "Nghề nghiệp cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (txtHoTenMe.Text.Length == 0 || txtHoTenMe.Text.Length > 40)
            {
                lblThongBao.Text = "Họ tên mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (txtNgheNghiepMe.Text.Length == 0 || txtNgheNghiepMe.Text.Length>40)
            {
                lblThongBao.Text = "Nghề nghiệp mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (cboNamHoc.Text.Length == 0)
            {
                lblThongBao.Text = "Vui lòng chọn năm học!!";
                lblThongBao.Visible = true;
            }
            else
            {
                int x;
                x = Convert.ToInt32(cboNamHoc.SelectedItem.ToString());
                //string ngay = dtpNgaySinh.Value.ToString("MM/dd/yyyy");
                lblThongBao.Visible = false;
                // Tạo DTo
                DTO_TiepNhanHocSinh hs = new DTO_TiepNhanHocSinh(0, txtHoTenHocSinh.Text, txtDiaChi.Text, dtpNgaySinh.Text, cboGioiTinh.Text, cboTonGiao.Text, cboDanToc.Text, txtHoTenCha.Text, txtNgheNghiepCha.Text, txtHoTenMe.Text, txtNgheNghiepMe.Text, x); // Vì ID tự tăng nên để ID số gì cũng dc

                // Them
                if (busHS.themHocSinh(hs))
                {
                    MessageBox.Show("Thêm thành công");
                    dgvHocSinh.DataSource = busHS.getHocSinh(); // refresh datagridview
                    Clear();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }

            }
        }
        private void dgvHocSinh_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvHocSinh.SelectedRows[0];
            btnThemVaoDanhSach.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            // Chuyển giá trị lên form
            txtMaHocSinh.Text = row.Cells[0].Value.ToString();
            txtHoTenHocSinh.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            dtpNgaySinh.Text = row.Cells[3].Value.ToString();
            cboGioiTinh.Text = row.Cells[4].Value.ToString();
            cboTonGiao.Text = row.Cells[5].Value.ToString();
            cboDanToc.Text = row.Cells[6].Value.ToString();
            txtHoTenCha.Text = row.Cells[7].Value.ToString();
            txtNgheNghiepCha.Text = row.Cells[8].Value.ToString();
            txtHoTenMe.Text = row.Cells[9].Value.ToString();
            txtNgheNghiepMe.Text = row.Cells[10].Value.ToString();
            cboNamHoc.Text = row.Cells[11].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            int x = Convert.ToInt32(cboNamHoc.SelectedItem.ToString());
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn xóa hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (dgvHocSinh.SelectedRows.Count > 0)
                {
                    lblThongBao.Visible = false;
                    // Lấy row hiện tại
                    DataGridViewRow row = dgvHocSinh.SelectedRows[0];
                    int ID = Convert.ToInt16(row.Cells[0].Value.ToString());

                    // Xóa
                    if (busHS.xoaHocSinh(ID, x))
                    {

                        MessageBox.Show("Xóa thành công");
                        dgvHocSinh.DataSource = busHS.getHocSinh(); // refresh datagridview
                        Clear();
                        btnXoa.Enabled = false;
                        btnSua.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Xóa ko thành công");
                    }
                }

                else
                {
                    MessageBox.Show("Hãy chọn thành viên muốn xóa");
                }
            }
        }

        private void btnTaySach_Click(object sender, EventArgs e)
        {
            Clear();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void Clear()
        {
            txtMaHocSinh.Clear();
            txtHoTenHocSinh.Clear();
            txtDiaChi.Clear();
            txtHoTenCha.Clear();
            txtHoTenMe.Clear();
            txtNgheNghiepCha.Clear();
            txtNgheNghiepMe.Clear();
            btnThemVaoDanhSach.Enabled = true;
            lblThongBao.Visible = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int dtp = dtpNgaySinh.Value.Year;
            // Kiểm tra nếu có chọn table rồi
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn sửa hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (dgvHocSinh.SelectedRows.Count > 0)
                {
                    if (txtHoTenHocSinh.Text.Length == 0 || txtHoTenHocSinh.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ và tên phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtDiaChi.Text.Length == 0 || txtDiaChi.Text.Length > 40)
                    {
                        lblThongBao.Text = "Địa chỉ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (dtp < 1999 || dtp > 2003)
                    {
                        lblThongBao.Text = "Năm sinh phải từ năm 1999 -> 2003!!";
                        lblThongBao.Visible = true;
                    }
                    else if (cboGioiTinh.Text.Length == 0)
                    {
                        lblThongBao.Text = "Vui lòng chọn giới tính!!";
                        lblThongBao.Visible = true;
                    }
                    else if (cboTonGiao.Text.Length == 0)
                    {
                        lblThongBao.Text = "Vui lòng chọn tôn giáo!!";
                        lblThongBao.Visible = true;
                    }
                    else if (cboDanToc.Text.Length == 0)
                    {
                        lblThongBao.Text = "Vui lòng chọn dân tộc!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtHoTenCha.Text.Length == 0 || txtHoTenCha.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ tên cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtNgheNghiepCha.Text.Length == 0 || txtNgheNghiepCha.Text.Length > 40)
                    {
                        lblThongBao.Text = "Nghề nghiệp cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtHoTenMe.Text.Length == 0 || txtHoTenMe.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ tên mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtNgheNghiepMe.Text.Length == 0 || txtNgheNghiepMe.Text.Length > 40)
                    {
                        lblThongBao.Text = "Nghề nghiệp mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (cboNamHoc.Text.Length == 0)
                    {
                        lblThongBao.Text = "Vui lòng chọn năm học!!";
                        lblThongBao.Visible = true;
                    }
                    else
                    {
                        // Lấy row hiện tại
                        DataGridViewRow row = dgvHocSinh.SelectedRows[0];
                        int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        int x = Convert.ToInt32(cboNamHoc.SelectedItem.ToString());
                        lblThongBao.Visible = false;
                        // Tạo DTo
                        DTO_TiepNhanHocSinh hs = new DTO_TiepNhanHocSinh(ID, txtHoTenHocSinh.Text, txtDiaChi.Text, dtpNgaySinh.Text, cboGioiTinh.Text, cboTonGiao.Text, cboDanToc.Text, txtHoTenCha.Text, txtNgheNghiepCha.Text, txtHoTenMe.Text, txtNgheNghiepMe.Text, x);
                        // Sửa
                        if (busHS.suaHocSinh(hs))
                        {
                            MessageBox.Show("Sửa thành công");
                            dgvHocSinh.DataSource = busHS.getHocSinh(); // refresh datagridview
                            Clear();
                            btnSua.Enabled = false;
                            btnXoa.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Sửa không thành công");
                        }
                    }
                }
             }
        }

        private void gbxHoSoHocSinh_Enter(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTonGiao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
