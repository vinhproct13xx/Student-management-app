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
using System.Data.SqlClient;

namespace GUI
{
    public partial class GUI_NHAPDIEM : Form
    {
        BUS_NHAPDIEM bu = new BUS_NHAPDIEM();
        public GUI_NHAPDIEM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";
          
            dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
            //dgvNhapDiem.DataSource = bu.getBangDiem("10A1", "1", "Toan");
        }

        private void Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
                    Lop.DataSource = bu.getMaLop(Khoi.Text);
                    Lop.DisplayMember = "MALOP";
                    String hk = null;
                    if (hocky1.Checked)
                        hk = "1";
                    else if (hocky2.Checked)
                        hk = "2";
                    dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
        }

        public string MonHoc (string a)
        {
            String monhoc = null;
            switch (a)
            {
                case "Toán":
                    monhoc = "Toan";
                    break;
                case "Lý":
                    monhoc = "Ly";
                    break;
                case "Hóa":
                    monhoc = "Hoa";
                    break;
                case "Sinh":
                    monhoc = "Sinh";
                    break;
                case "Văn":
                    monhoc = "Van";
                    break;
                case "Sử":
                    monhoc = "Su";
                    break;
                case "Địa":
                    monhoc = "Dia";
                    break;
                case "Giáo Dục Công Dân":
                    monhoc = "GDCD";
                    break;
                case "Công Nghệ":
                    monhoc = "CongNghe";
                    break;
                case "Tin Học":
                    monhoc = "TinHoc";
                    break;
                case "Ngoại Ngữ":
                    monhoc = "NgoaiNgu";
                    break;
                case "Giáo Dục Quốc Phòng":
                    monhoc = "GDQP";
                    break;
                case "Thể Dục":
                    monhoc = "TheDuc";
                    break;
            }
            return monhoc;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hocky2_CheckedChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";

            dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thật sự muốn thoát hay không?", "Thông Báo!!", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
                Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hocky1_CheckedChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";

            dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
        }

        private void Luu_Click(object sender, EventArgs e)
        {
            Thoat.Enabled = false;
            if (Khoi.Text == "")
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn khối!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else if (Lop.Text == "")
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn lớp!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else if (Mon.Text == "")
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn môn!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else if (hocky1.Checked == false && hocky2.Checked == false)
            {
                DialogResult dlr = MessageBox.Show("Vui lòng chọn học kì!", "Thông Báo!!", MessageBoxButtons.YesNo);
            }
            else
            {
                //dgvNhapDiem.Columns[2].DefaultCellStyle.Format = "";
                //int dem = 0;
                //float tong = 0;
                //int i = 0;
                //foreach (DataRow rows in dgvNhapDiem.Rows)
                //{
                //    DataGridViewRow row = dgvNhapDiem.SelectedRows[i];
                //    if (row.Cells[2].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[2].Value.ToString());
                //        if (row.Cells[3].Value.ToString() != null)
                //        {
                //            dem += 1;
                //            tong += float.Parse(row.Cells[3].Value.ToString());
                //            if (row.Cells[4].Value.ToString() != null)
                //            {
                //                dem += 1;
                //                tong += float.Parse(row.Cells[4].Value.ToString());
                //                if (row.Cells[5].Value.ToString() != null)
                //                {
                //                    dem += 1;
                //                    tong += float.Parse(row.Cells[5].Value.ToString());
                //                    if (row.Cells[6].Value.ToString() != null)
                //                    {
                //                        dem += 1;
                //                        tong += float.Parse(row.Cells[6].Value.ToString());
                //                    }
                //                }
                //            }
                //        }
                //    }
                //    float MTB;
                //    MTB = tong / dem;
                //    tong = MTB;
                //    if (tong != 0)
                //        dem = 1;
                //    if (row.Cells[7].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[7].Value.ToString());
                //    }
                //    if (row.Cells[8].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[8].Value.ToString());
                //    }
                //    if (row.Cells[9].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[9].Value.ToString());
                //    }
                //    if (row.Cells[10].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[10].Value.ToString());
                //    }
                //    if (row.Cells[11].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[11].Value.ToString());
                //    }
                //    if (row.Cells[12].Value.ToString() != null)
                //    {
                //        dem += 1;
                //        tong += float.Parse(row.Cells[12].Value.ToString());
                //    }
                //    if (row.Cells[13].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[13].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[14].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[14].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[15].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[15].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[16].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[16].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[17].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[17].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[18].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[18].Value.ToString()) * 2;
                //    }
                //    if (row.Cells[19].Value.ToString() != null)
                //    {
                //        dem += 2;
                //        tong += float.Parse(row.Cells[19].Value.ToString()) * 3;
                //    }
                //    float a = tong / dem;
                //    row.Cells[20].Value = a;
                //    i++;
                //}

                bu.CapNhatDiem();

                String hk = null;
                if (hocky1.Checked)
                    hk = "1";
                else if (hocky2.Checked)
                    hk = "2";
                dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
                DialogResult dlr = MessageBox.Show("Lưu thành công!", "Thông Báo!!", MessageBoxButtons.YesNo);

            }
        }

        private void Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            String hk = null;
            if (hocky1.Checked)
                hk = "1";
            else if (hocky2.Checked)
                hk = "2";

            dgvNhapDiem.DataSource = bu.getBangDiem(Lop.Text, hk, MonHoc(Mon.Text));
            
        }

        private void Mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
