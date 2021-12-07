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
        DTO_ThayDoiQuyDinh dtoQuyDinh = new DTO_ThayDoiQuyDinh();


        /// <summary>
        /// khai báo biến chung
        /// tuoimax, tuoimin,..... (các thuộc tính của dtoQuyDinh
        /// </summary>
        /// 
        int tuoimax, tuoimin, siso, diemdat, diemmax, diemmin, slmon, lop10, lop11, lop12;
       

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


            dtoQuyDinh._TuoiMax = int.Parse(dtQuyDinh.Rows[0][0].ToString());
            dtoQuyDinh._TuoiMin = int.Parse(dtQuyDinh.Rows[0][1].ToString());
            dtoQuyDinh._SiSo = int.Parse(dtQuyDinh.Rows[0][2].ToString());
            dtoQuyDinh._DiemDat = int.Parse(dtQuyDinh.Rows[0][3].ToString());
            dtoQuyDinh._DiemMax = int.Parse(dtQuyDinh.Rows[0][4].ToString());
            dtoQuyDinh._DiemMin = int.Parse(dtQuyDinh.Rows[0][5].ToString());
            dtoQuyDinh._SLMon = int.Parse(dtQuyDinh.Rows[0][6].ToString());
            dtoQuyDinh._Lop10 = int.Parse(dtQuyDinh.Rows[0][7].ToString());
            dtoQuyDinh._Lop11 = int.Parse(dtQuyDinh.Rows[0][8].ToString()); 
            dtoQuyDinh._Lop12 = int.Parse(dtQuyDinh.Rows[0][9].ToString());

            nudTuoiMax.Value = dtoQuyDinh._TuoiMax;
            nudTuoiMin.Value = dtoQuyDinh._TuoiMin;
            nudSiSo.Value = dtoQuyDinh._SiSo;
            nudDiemDat.Value = dtoQuyDinh._DiemDat;
            nudDiemMax.Value = dtoQuyDinh._DiemMax;
            nudDiemMin.Value = dtoQuyDinh._DiemMin;
            nudSLMon.Value = dtoQuyDinh._SLMon;
            nudLop10.Value = dtoQuyDinh._Lop10;
            nudLop11.Value = dtoQuyDinh._Lop11;
            nudLop12.Value = dtoQuyDinh._Lop12;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dtoQuyDinh._TuoiMax = Convert.ToInt32(Math.Round(nudTuoiMax.Value, 0));
            dtoQuyDinh._TuoiMin = Convert.ToInt32(Math.Round(nudTuoiMin.Value, 0));
            dtoQuyDinh._SiSo = Convert.ToInt32(Math.Round(nudSiSo.Value, 0));
            dtoQuyDinh._DiemDat = Convert.ToInt32(Math.Round(nudDiemDat.Value, 0));
            dtoQuyDinh._DiemMax = Convert.ToInt32(Math.Round(nudDiemMax.Value, 0));
            dtoQuyDinh._DiemMin = Convert.ToInt32(Math.Round(nudDiemMin.Value, 0));
            dtoQuyDinh._SLMon = Convert.ToInt32(Math.Round(nudSLMon.Value, 0));
            dtoQuyDinh._Lop10 = Convert.ToInt32(Math.Round(nudLop10.Value, 0));
            dtoQuyDinh._Lop11 = Convert.ToInt32(Math.Round(nudLop11.Value, 0));
            dtoQuyDinh._Lop12 = Convert.ToInt32(Math.Round(nudLop12.Value, 0));
            busQuyDinh.AddQuyDinh(dtoQuyDinh);
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

        private void nudSLMon_ValueChanged(object sender, EventArgs e)
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
