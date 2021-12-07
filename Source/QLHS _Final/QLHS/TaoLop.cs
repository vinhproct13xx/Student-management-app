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
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        BUS_ThayDoiQuyDinh busQuyDinh = new BUS_ThayDoiQuyDinh();

        /// <summary>
        /// các biến chung trong hàm
        /// </summary>
        /// 
        int MaLop;
        int MaNH;
        int MaHS;
        int SiSo;
        List<int> listmaHS = new List<int>();
        List<DTO_MonHoc> lMonHoc = new List<DTO_MonHoc>();
        List<int> lMaMH = new List<int>();
        public TaoLop()
        {
            InitializeComponent();
        }
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
        void GetSiSo()
        {
            DataTable dt = new DataTable();
            dt = busQuyDinh.getQuyDinh();
            SiSo = int.Parse(dt.Rows[0][2].ToString());
            // MessageBox.Show("Si so = " +SiSo);
        }

        /// <summary>
        /// hiển thị danh sách năm học lên combobox
        /// </summary>
        public void HienThiNamHoc()
        {
            List<DTO_NamHoc> lNamHoc = busNamHoc.bgetListNamHoc();
            cboNamHoc.DataSource = lNamHoc;
            cboNamHoc.DisplayMember = "TENNH";
            cboNamHoc.ValueMember = "MANH";
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
            GetSiSo();

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



        private void btnChuyenLop_Click_1(object sender, EventArgs e)
        {
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue);
            MaLop = Convert.ToInt32(cboLop.SelectedValue);
            int temp = 0;
            List<int> temps = new List<int>();
            foreach (int item in listmaHS)
            {
                if (busTaoLop.CheckSiSo(SiSo, MaLop, MaNH) == true)
                {
                    busTaoLop.ChuyenLop(item, MaLop, MaNH);
                    temp++;
                    temps.Add(item);
                }

            }
            if (temp < listmaHS.Count)
            {
                MessageBox.Show("Sĩ số lớp đã tối đa (" + SiSo + "). Không thể thêm " + (listmaHS.Count - temp) + " học sinh!");
            }
            DSLopCoSan.DataSource = busLopCoSan.getLopHocCoSan(MaNH, MaLop);
            HSChuaCoLop.DataSource = busTaoLop.getDSLop();
            //insert data vao bang DTB

            lMonHoc = busMonHoc.bgetlistMonHoc();

            for (int i = 0; i < lMonHoc.Count; i++)
            {
                lMaMH.Add(lMonHoc[i].MaMH);

            }
            foreach (int item in lMaMH)
            {
                busTaoLop.InsertBaoCao(MaNH, MaLop, item);
                foreach (int i in listmaHS)
                {
                    busTaoLop.InsertDataDiemTBMon(MaNH, MaLop, item, i);
                }
            }
            foreach (int i in temps)
            {
                busTaoLop.InsertDiemTBChung(MaNH, MaLop, i);
            }
            busTaoLop.InsertBaoCaoChung(MaNH, MaLop);
            listmaHS.Clear();
            lMonHoc.Clear();
            lMaMH.Clear();
            temps.Clear();
        }


        private void HSChuaCoLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = HSChuaCoLop.CurrentRow.Index;
            MaHS = int.Parse(HSChuaCoLop[0, row].Value.ToString());
            listmaHS.Add(MaHS);
        }

      
    }
}
