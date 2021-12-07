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

        }

        public void LayBangDiem(ListView lbd, ListViewGroup bd, BANGDIEM BD)
        {
            string sql = "select HSHS.MAHS, HOTEN, KTM1, KTM2, KTM3, KTM4, KTM5, KT15P1, KT15P2, KT15P3, KT15P4, KT15P5, KT15P6, KT1T1, KT1T2, KT1T3, KT1T4, KT1T5, KT1T6, DIEMTHI, DIEMTB from HSHS, BANGDIEM where HSHS.MAHS = BANGDIEM.MAHS, MAHK = " + BD.MAHK + ", MALOP = " + BD.MALOP + ", MAMONHOC = " + BD.MAMONHOC + ", MANAMHOC = " + BD.MANAMHOC;
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Sodiem_TextChanged(object sender, EventArgs e)
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

        }

        private void TiepTheo_Click(object sender, EventArgs e)
        {
            QuayLai.Enabled = false;
            Thoat.Enabled = false;
            lblThongBao.Visible = true;
            if (Khoi.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn khối!";
                lblThongBao.Visible = true;
            }
            else if (Lop.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn lớp!";
                lblThongBao.Visible = true;
            }
            else if (Mon.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn môn!";
                lblThongBao.Visible = true;
            }
            else if (hocky1.Enabled == false && hocky2.Enabled == false)
            {
                lblThongBao.Text = "Vui lòng chọn học kỳ!";
            }
            else if (LoaiDiem.Text == "")
            {
                lblThongBao.Text = "Vui lòng chọn loại điểm!";
                lblThongBao.Visible = true;
            }
            else if (IsNumber(Sodiem.Text) == false || Sodiem.Text.Length > 1)
            {
                if (Sodiem.Text != "10")
                {
                    lblThongBao.Text = "Điểm phải là 1 số từ 0 đến 10";
                    lblThongBao.Visible = true;
                }
            }



        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoaiDiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void MaHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Mon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Khoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
