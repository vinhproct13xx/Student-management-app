using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace GUI
{
    public partial class GUI_HANHKIEM : Form
    {
        DAL_HANHKIEM da = new DAL_HANHKIEM();
        public GUI_HANHKIEM()
        {
            InitializeComponent();
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            int kt = 0;
            if (Khoi.Text == "")
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn khối!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else if (Lop.Text == "")
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn lớp!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else if (hocky1.Checked == false && hocky2.Checked == false)
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn học kì!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else
            {
                for (int i = 0; i < dgvNhapHanhKiem.Rows.Count - 1; i++)
                { 
                    int CurrentIndex = i;
                    if (dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "T" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Tot" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "tot" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "tốt" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "t")
                    {
                        dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value = "Tốt";
                    }
                    if (dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "K" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Kha" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "kha" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "khá" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "k")
                    {
                        dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value = "Khá";
                    }
                    if (dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "TB" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Trung Binh" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "trung binh" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "trung bình" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Tb" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "tb")
                    {
                        dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value = "Trung Bình";
                    }
                    if (dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Y" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Yeu" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "yếu" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "yeu" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "y")
                    {
                        dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value = "Yếu";
                    }
                    if (dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Tốt" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Khá" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Trung Bình" || dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() == "Yếu")
                    {
                        da.CapNhatDiem(dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString(), dgvNhapHanhKiem.Rows[CurrentIndex].Cells[0].Value.ToString(), Lop.Text, hk);
                        //DialogResult dl = MessageBox.Show(dgvNhapHanhKiem.Rows[CurrentIndex].Cells[2].Value.ToString() + dgvNhapHanhKiem.Rows[CurrentIndex].Cells[0].Value.ToString(), "Thông Báo!!", MessageBoxButtons.YesNo);  
                    }
                    else
                    {
                        DialogResult dl = MessageBox.Show("Hạnh Kiểm phải là Tốt, Khá, Trung Bình hoặc Yếu", "Lỗi ở mã học sinh " + dgvNhapHanhKiem.Rows[CurrentIndex].Cells[0].Value.ToString() + "!!", MessageBoxButtons.YesNo);
                        kt = 1;
                        break;
                    }
                }                         
            }
            if (kt == 0)
            {
                DialogResult d = MessageBox.Show("Lưu thành công!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn thoát hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lop.DataSource = da.getMaLop(Khoi.Text);
            Lop.DisplayMember = "MALOP";
           
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }

        private void Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }

        private void hocky1_CheckedChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }

        private void hocky2_CheckedChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GUI_HANHKIEM_Load(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
            dgvNhapHanhKiem.DataSource = da.getBangDiem(Lop.Text, hk);
        }

        private void dgvNhapHanhKiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
