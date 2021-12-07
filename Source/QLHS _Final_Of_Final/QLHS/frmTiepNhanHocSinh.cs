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
        BUS_ThayDoiQuyDinh busQuyDinh = new BUS_ThayDoiQuyDinh();
        DTO_ThayDoiQuyDinh dtoQuyDinh = new DTO_ThayDoiQuyDinh();
        public frmTiepNhanHocSinh()
        {
            InitializeComponent();
        }
        void getTuoi()
        {
            DataTable dt = new DataTable();
            dt = busQuyDinh.getQuyDinh();
            dtoQuyDinh.TuoiMax = int.Parse(dt.Rows[0][0].ToString());
            dtoQuyDinh.TuoiMin = int.Parse(dt.Rows[0][1].ToString());
        }
        static public bool KiemTraHoTen(string hoTen)
        {
            if (hoTen.IndexOf(" ") == -1) return false;
            string[] arr = hoTen.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLower(arr[i][0]) == true) return false;
            }
            return true;
        }
        private void frmTiepNhanHocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = busHS.getHocSinh();
            getTuoi();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public bool IsChar(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (char.IsDigit(a[i]) == true || a[i] == '!' || a[i] == '-' || a[i] == '.'|| a[i] == '@' || a[i] == '#' || a[i] == '$' || a[i] == '%' || a[i] == '^' || a[i] == '&' || a[i] == '*' || a[i] == '(' || a[i] == ')' || a[i] == '_' || a[i] == '+' || a[i] == '=' || a[i] == ',' || a[i] == '{' || a[i] == '}' || a[i] == '[' || a[i] == ']' || a[i] == '|' || a[i] == '\\' || a[i] == ';' || a[i] == ':' || a[i] == '"' || a[i] == '\'' || a[i] == '<' || a[i] == '>' || a[i] == '?' || a[i] == '/' || a[i] == '`' || a[i] == '~')  
                    return false;
            }
            return true;
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
            string dmy = dtpNgaySinh.Value.ToString("MM/dd/yyyy");
            int year = DateTime.Now.Year;
            int dtp = dtpNgaySinh.Value.Year;
            if (IsChar(txtHoTenHocSinh.Text) == false)
            {
                lblThongBao.Text = "Họ và tên không được có số và ký tự đặc biệt!!";
                lblThongBao.Visible = true;
            }
            else if (KiemTraHoTen(txtHoTenHocSinh.Text)==false)
            {
                lblThongBao.Text = "Họ và tên phải viết hoa chữ cái đầu!!";
                lblThongBao.Visible = true;
            }
            else if (txtHoTenHocSinh.Text.Length == 0 || txtHoTenHocSinh.Text.Length > 40)
            {
                lblThongBao.Text = "Họ và tên phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (txtDiaChi.Text.Length == 0 || txtDiaChi.Text.Length > 40)
            {
                lblThongBao.Text = "Địa chỉ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if ((year - dtp) < dtoQuyDinh.TuoiMin || (year - dtp) > dtoQuyDinh.TuoiMax)
            {
                lblThongBao.Text = "Năm sinh phải từ năm " + (year - dtoQuyDinh.TuoiMax) + "->" + (year - dtoQuyDinh.TuoiMin) + "!!";
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
            else if (IsChar(txtHoTenCha.Text) == false)
            {
                lblThongBao.Text = "Họ tên cha không được có số và ký tự đặc biệt!!";
                lblThongBao.Visible = true;
            }
            else if (KiemTraHoTen(txtHoTenCha.Text) == false)
            {
                lblThongBao.Text = "Họ tên cha phải viết hoa chữ cái đầu!!";
                lblThongBao.Visible = true;
            }
            else if (txtHoTenCha.Text.Length == 0 || txtHoTenCha.Text.Length > 40)
            {
                lblThongBao.Text = "Họ tên cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (IsChar(txtNgheNghiepCha.Text) == false)
            {
                lblThongBao.Text = "Nghề nghiệp cha không được có số và ký tự đặc biệt!!";
                lblThongBao.Visible = true;
            }
            else if (txtNgheNghiepCha.Text.Length == 0 || txtNgheNghiepCha.Text.Length>40)
            {
                lblThongBao.Text = "Nghề nghiệp cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (IsChar(txtHoTenMe.Text) == false)
            {
                lblThongBao.Text = "Họ tên mẹ không được có số và ký tự đặc biệt!!";
                lblThongBao.Visible = true;
            }
            else if (KiemTraHoTen(txtHoTenMe.Text) == false)
            {
                lblThongBao.Text = "Họ tên mẹ phải viết hoa chữ cái đầu!!";
                lblThongBao.Visible = true;
            }
            else if (txtHoTenMe.Text.Length == 0 || txtHoTenMe.Text.Length > 40)
            {
                lblThongBao.Text = "Họ tên mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else if (IsChar(txtNgheNghiepMe.Text) == false)
            {
                lblThongBao.Text = "Nghề nghiệp mẹ không được có số và ký tự đặc biệt!!";
                lblThongBao.Visible = true;
            }
            else if (txtNgheNghiepMe.Text.Length == 0 || txtNgheNghiepMe.Text.Length>40)
            {
                lblThongBao.Text = "Nghề nghiệp mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                lblThongBao.Visible = true;
            }
            else
            {
                lblThongBao.Visible = false;
                // Tạo DTo
                DTO_TiepNhanHocSinh hs = new DTO_TiepNhanHocSinh(0, txtHoTenHocSinh.Text, txtDiaChi.Text, dmy, cboGioiTinh.Text, cboTonGiao.Text, cboDanToc.Text, txtHoTenCha.Text, txtNgheNghiepCha.Text, txtHoTenMe.Text, txtNgheNghiepMe.Text); // Vì ID tự tăng nên để ID số gì cũng dc

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
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
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
                    busHS.xoaHocSinh(ID);
                    MessageBox.Show("Xóa thành công");
                    dgvHocSinh.DataSource = busHS.getHocSinh(); // refresh datagridview
                    Clear();
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
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
            string dmy = dtpNgaySinh.Value.ToString("MM/dd/yyyy");
            int year = DateTime.Now.Year;
            int dtp = dtpNgaySinh.Value.Year;
            // Kiểm tra nếu có chọn table rồi
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn sửa hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                if (dgvHocSinh.SelectedRows.Count > 0)
                {
                    if (IsChar(txtHoTenHocSinh.Text) == false)
                    {
                        lblThongBao.Text = "Họ và tên không được có số và ký tự đặc biệt!!";
                        lblThongBao.Visible = true;
                    }
                    else if (KiemTraHoTen(txtHoTenHocSinh.Text) == false)
                    {
                        lblThongBao.Text = "Họ và tên phải viết hoa chữ cái đầu!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtHoTenHocSinh.Text.Length == 0 || txtHoTenHocSinh.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ và tên phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtDiaChi.Text.Length == 0 || txtDiaChi.Text.Length > 40)
                    {
                        lblThongBao.Text = "Địa chỉ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if ((year - dtp) <= dtoQuyDinh.TuoiMin || (year - dtp) >= dtoQuyDinh.TuoiMax)
                    {
                        lblThongBao.Text = "Năm sinh phải từ năm " + (year - dtoQuyDinh.TuoiMax) + "->" + (year - dtoQuyDinh.TuoiMin) + "!!";
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
                    else if (IsChar(txtHoTenCha.Text) == false)
                    {
                        lblThongBao.Text = "Họ tên cha không được có số và ký tự đặc biệt!!";
                        lblThongBao.Visible = true;
                    }
                    else if (KiemTraHoTen(txtHoTenCha.Text) == false)
                    {
                        lblThongBao.Text = "Họ tên cha phải viết hoa chữ cái đầu!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtHoTenCha.Text.Length == 0 || txtHoTenCha.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ tên cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (IsChar(txtNgheNghiepCha.Text) == false)
                    {
                        lblThongBao.Text = "Nghề nghiệp cha không được có số và ký tự đặc biệt!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtNgheNghiepCha.Text.Length == 0 || txtNgheNghiepCha.Text.Length > 40)
                    {
                        lblThongBao.Text = "Nghề nghiệp cha phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (IsChar(txtHoTenMe.Text) == false)
                    {
                        lblThongBao.Text = "Họ tên mẹ không được có số và ký tự đặc biệt!!";
                        lblThongBao.Visible = true;
                    }
                    else if (KiemTraHoTen(txtHoTenMe.Text) == false)
                    {
                        lblThongBao.Text = "Họ tên mẹ phải viết hoa chữ cái đầu!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtHoTenMe.Text.Length == 0 || txtHoTenMe.Text.Length > 40)
                    {
                        lblThongBao.Text = "Họ tên mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else if (IsChar(txtNgheNghiepMe.Text) == false)
                    {
                        lblThongBao.Text = "Nghề nghiệp mẹ không được có số và ký tự đặc biệt!!";
                        lblThongBao.Visible = true;
                    }
                    else if (txtNgheNghiepMe.Text.Length == 0 || txtNgheNghiepMe.Text.Length > 40)
                    {
                        lblThongBao.Text = "Nghề nghiệp mẹ phải lớn hơn 0 và nhỏ hơn 40 kí tự!!";
                        lblThongBao.Visible = true;
                    }
                    else
                    {
                        // Lấy row hiện tại
                        DataGridViewRow row = dgvHocSinh.SelectedRows[0];
                        int ID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        lblThongBao.Visible = false;
                        // Tạo DTo
                        DTO_TiepNhanHocSinh hs = new DTO_TiepNhanHocSinh(ID, txtHoTenHocSinh.Text, txtDiaChi.Text, dmy, cboGioiTinh.Text, cboTonGiao.Text, cboDanToc.Text, txtHoTenCha.Text, txtNgheNghiepCha.Text, txtHoTenMe.Text, txtNgheNghiepMe.Text);
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
    }
}
