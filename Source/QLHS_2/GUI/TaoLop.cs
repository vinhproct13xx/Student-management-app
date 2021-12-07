using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class TaoLop : Form
    {
        /// <summary>
        /// danh sách các học sinh chưa có lớp
        /// danh sách lớp ở combobox
        /// danh sách năm hoc ở combobox
        /// lấy dữ liệu từ database
        /// </summary>

        BUS_TaoLop busTaoLop = new BUS_TaoLop();
        BUS_TaoLop busLopCoSan = new BUS_TaoLop();
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        BUS_NamHoc busNamHoc = new BUS_NamHoc();

        /// <summary>
        /// các biến chung trong hàm
        /// </summary>
        /// 
        int MaLop;
        int MaNH;
        int MaHS;
        List<int> listmaHS = new List<int>();
        public TaoLop()
        {
            InitializeComponent();
        }

    
        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int row = HSChuaCoLop.CurrentRow.Index;
        //    MaHS = int.Parse(HSChuaCoLop[0, row].Value.ToString());
        //}
        /// <summary>
        /// hiển thị các lớp lên combobox
        /// </summary>
        public void HienThiLop()
        {
            List<DTO_LopHoc> dt = busLopHoc.bgetlistLopHoc();
            cboLop.DataSource = dt;
            cboLop.DisplayMember = "TENLOP";
            cboLop.ValueMember = "MALOP";
        }

        /// <summary>
        /// hiển thị danh sách năm học lên combobox
        /// </summary>
        public void HienThiNamHoc()
        {
            List<DTO_NamHoc> lNamHoc = busNamHoc.bgetListNamHoc();
            cboNamHoc.DataSource = lNamHoc;
            cboNamHoc.DisplayMember = "tennh";
            cboNamHoc.ValueMember = "manh";
                
        }
        /// <summary>
        /// from load: đọc dữ liệu ngay từ đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void Form1_Load(object sender, EventArgs e)
        {
            HSChuaCoLop.DataSource = busTaoLop.getDSLop();//phần bên trái
            HienThiLop();
            HienThiNamHoc();



        }

      public void LoadDShocSinh(int MaNH, int MaLop)
        {

        }


        private void cboNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// xem danh sách lớp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXem(object sender, EventArgs e)
        {
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue);
            MaLop = Convert.ToInt32(cboLop.SelectedValue);
            if (int.Parse(DateTime.Now.Month.ToString()) < 9)
            {


                if (MaNH == int.Parse(DateTime.Now.Year.ToString()) - 1)
                {
                    DSLopCoSan.DataSource = busLopCoSan.getLopHocCoSan(MaNH, MaLop);
                }
                else
                {
                    MessageBox.Show("Chọn năm hiện tại " + DateTime.Now.Year);
                }
            }
            else
            {
                if (MaNH == int.Parse(DateTime.Now.Year.ToString()))
                {
                    DSLopCoSan.DataSource = busLopCoSan.getLopHocCoSan(MaNH, MaLop);
                }
                else
                {
                    MessageBox.Show("Chọn năm hiện tại " + DateTime.Now.Year);
                }
            }

        }
        void GetDSHocSinhTheoLop(int _MaNH, int _MaLop)
        {

        }

  

        private void btnChuyenLop_Click_1(object sender, EventArgs e)
        {
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue);
            MaLop = Convert.ToInt32(cboLop.SelectedValue);
            foreach( int item in listmaHS)
            {
                busTaoLop.ChuyenLop(item, MaLop, MaNH);
            }
            DSLopCoSan.DataSource = busLopCoSan.getLopHocCoSan(MaNH, MaLop);
            HSChuaCoLop.DataSource = busTaoLop.getDSLop();
        }

       
        private void HSChuaCoLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = HSChuaCoLop.CurrentRow.Index;

            MaHS = int.Parse(HSChuaCoLop[0, row].Value.ToString());
            listmaHS.Add(MaHS);
        }

        private void HSChuaCoLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
