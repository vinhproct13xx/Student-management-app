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
    public partial class frmThayDoiQuyDinh : Form
    {
        BUS_ThayDoiQuyDinh busQuyDinh = new BUS_ThayDoiQuyDinh();
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        DTO_ThayDoiQuyDinh dtoQuyDinh = new DTO_ThayDoiQuyDinh();
        DTO_ThayDoiQuyDinh temp = new DTO_ThayDoiQuyDinh();


        /// <summary>
        /// khai báo biến chung
        /// tuoimax, tuoimin,..... (các thuộc tính của dtoQuyDinh
        /// </summary>
        /// 


        public frmThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void frmThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            HienThiQuyDinh();
        }

        public void HienThiQuyDinh()
        {
            DataTable dtQuyDinh = busQuyDinh.getQuyDinh();
            dtoQuyDinh.TuoiMax = int.Parse(dtQuyDinh.Rows[0][0].ToString());
            dtoQuyDinh.TuoiMin = int.Parse(dtQuyDinh.Rows[0][1].ToString());
            dtoQuyDinh.SiSo = int.Parse(dtQuyDinh.Rows[0][2].ToString());
            dtoQuyDinh.DiemDat = int.Parse(dtQuyDinh.Rows[0][3].ToString());
            dtoQuyDinh.DiemMax = int.Parse(dtQuyDinh.Rows[0][4].ToString());
            dtoQuyDinh.DiemMin = int.Parse(dtQuyDinh.Rows[0][5].ToString());
            dtoQuyDinh.Lop10 = int.Parse(dtQuyDinh.Rows[0][6].ToString());
            dtoQuyDinh.Lop11 = int.Parse(dtQuyDinh.Rows[0][7].ToString());
            dtoQuyDinh.Lop12 = int.Parse(dtQuyDinh.Rows[0][8].ToString());

            nudTuoiMax.Value = dtoQuyDinh.TuoiMax;
            nudTuoiMin.Value = dtoQuyDinh.TuoiMin;
            nudSiSo.Value = dtoQuyDinh.SiSo;
            nudDiemDat.Value = dtoQuyDinh.DiemDat;
            nudDiemMax.Value = dtoQuyDinh.DiemMax;
            nudDiemMin.Value = dtoQuyDinh.DiemMin;
            nudLop10.Value = dtoQuyDinh.Lop10;
            nudLop11.Value = dtoQuyDinh.Lop11;
            nudLop12.Value = dtoQuyDinh.Lop12;

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtQuyDinh = busQuyDinh.getQuyDinh();
            temp.TuoiMax = int.Parse(dtQuyDinh.Rows[0][0].ToString());
            temp.TuoiMin = int.Parse(dtQuyDinh.Rows[0][1].ToString());
            temp.SiSo = int.Parse(dtQuyDinh.Rows[0][2].ToString());
            temp.DiemDat = int.Parse(dtQuyDinh.Rows[0][3].ToString());
            temp.DiemMax = int.Parse(dtQuyDinh.Rows[0][4].ToString());
            temp.DiemMin = int.Parse(dtQuyDinh.Rows[0][5].ToString());
            temp.Lop10 = busLopHoc.CountClass(10);
            temp.Lop11 = busLopHoc.CountClass(11);
            temp.Lop12 = busLopHoc.CountClass(12);
            dtoQuyDinh.TuoiMax = Convert.ToInt32(Math.Round(nudTuoiMax.Value, 0));
            dtoQuyDinh.TuoiMin = Convert.ToInt32(Math.Round(nudTuoiMin.Value, 0));
            dtoQuyDinh.SiSo = Convert.ToInt32(Math.Round(nudSiSo.Value, 0));
            dtoQuyDinh.DiemDat = Convert.ToInt32(Math.Round(nudDiemDat.Value, 0));
            dtoQuyDinh.DiemMax = Convert.ToInt32(Math.Round(nudDiemMax.Value, 0));
            dtoQuyDinh.DiemMin = Convert.ToInt32(Math.Round(nudDiemMin.Value, 0));
            dtoQuyDinh.Lop10 = Convert.ToInt32(Math.Round(nudLop10.Value, 0));
            dtoQuyDinh.Lop11 = Convert.ToInt32(Math.Round(nudLop11.Value, 0));
            dtoQuyDinh.Lop12 = Convert.ToInt32(Math.Round(nudLop12.Value, 0));
            if (dtoQuyDinh.SiSo < temp.SiSo)
                MessageBox.Show("Sĩ số lớp phải lớn hơn sĩ số lớp hiện tại");
            else
            {
                busQuyDinh.AddQuyDinh(dtoQuyDinh);
                MessageBox.Show(" Đã thay đổi quy định!");
            }
            if (dtoQuyDinh.Lop10 > temp.Lop10)
            {
                busLopHoc.AddClass((dtoQuyDinh.Lop10 - temp.Lop10), 10);
            }
            if (dtoQuyDinh.Lop11 > temp.Lop11)
            {
                busLopHoc.AddClass((dtoQuyDinh.Lop11 - temp.Lop11), 11);
            }
            if (dtoQuyDinh.Lop12 > temp.Lop12)
            {
                busLopHoc.AddClass((dtoQuyDinh.Lop12 - temp.Lop12), 12);
            }
            HienThiQuyDinh();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void nudTuoiMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudTuoiMax_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void nudLop11_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudLop12_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nudLop10_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudSiSo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void nudDiemDat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void nudDiemMin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void nudDiemMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudTuoiMax_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
