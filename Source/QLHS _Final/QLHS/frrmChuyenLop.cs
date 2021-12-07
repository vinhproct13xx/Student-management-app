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
    public partial class frmChuyenLop : Form
    {
        /// <summary>
        /// lấy danh sách lớp học, năm học lên combobox
        /// lấy danh sách cần chuyển vaofo datagridview
        /// </summary>
        BUS_LopHoc busLopHoc = new BUS_LopHoc();//lớp cũ
        BUS_LopHoc busLopHoc2 = new BUS_LopHoc();//lớp mới
        BUS_NamHoc busNamHoc2 = new BUS_NamHoc();//lớp mới
        BUS_NamHoc busNamHoc = new BUS_NamHoc();//lớp cũ
        BUS_ChuyenLop busChuyenLop = new BUS_ChuyenLop();//lớp cũ
        BUS_ChuyenLop busChuyenLop2 = new BUS_ChuyenLop();//lớp mới
        BUS_MonHoc busMonHoc = new BUS_MonHoc();//danh sachs mon hoc
        BUS_ThayDoiQuyDinh busQuyDinh = new BUS_ThayDoiQuyDinh();
        /// <summary>
        /// biến chung, truyền vào làm đối số cho các hàm
        /// </summary>
        int MaHS;
        int OldMaLop;
        int OldMaNH;
        int MaLop;
        int MaNH;
        int SiSo;
        List<int> lMaHS = new List<int>();
        List<int> lMaHS2 = new List<int>();//chuyen nguoc lai
        public frmChuyenLop()
        {
            InitializeComponent();
        }

        /// <summary>
        /// hiển thị các lớp lên combobox
        /// </summary>
        public void HienThiLop()
        {
            List<DTO_LopHoc> dt2 = busLopHoc2.bgetlistLopHoc();
            cboLopHoc.DataSource = dt2;
            cboLopHoc.DisplayMember = "TENLOP";
            cboLopHoc.ValueMember = "MALOP";
            List<DTO_LopHoc> dt = busLopHoc.bgetlistLopHoc();
            cbOldLopHoc.DataSource = dt;
            cbOldLopHoc.DisplayMember = "TENLOP";
            cbOldLopHoc.ValueMember = "MALOP";
        }

        /// <summary>
        /// hiển thị danh sách năm học lên combobox
        /// </summary>
        public void HienThiNamHoc()
        {
            List<DTO_NamHoc> lNamHoc2 = busNamHoc2.bgetListNamHoc();
            cboNamHoc.DataSource = lNamHoc2;
            cboNamHoc.DisplayMember = "tennh";
            cboNamHoc.ValueMember = "manh";
            List<DTO_NamHoc> lNamHoc = busNamHoc.bgetListNamHoc();
            cbOldNamHoc.DataSource = lNamHoc;
            cbOldNamHoc.DisplayMember = "TenNH";
            cbOldNamHoc.ValueMember = "manh";

        }
        void GetSiSo()
        {
            DataTable dt = new DataTable();
            dt = busQuyDinh.getQuyDinh();
            SiSo = int.Parse(dt.Rows[0][2].ToString());
        }


        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            HienThiLop();
            HienThiNamHoc();
            GetSiSo();

        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            OldMaNH = Convert.ToInt32(cbOldNamHoc.SelectedValue);
            OldMaLop = Convert.ToInt32(cbOldLopHoc.SelectedValue);
            try
            {
                dgvDSLop.DataSource = busChuyenLop.getDSLop(OldMaNH, OldMaLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được danh sách lớp cũ!");
            }

        }

        private void btnXemLop_Click(object sender, EventArgs e)
        {
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue);
            MaLop = Convert.ToInt32(cboLopHoc.SelectedValue);
            try
            {
                dgvDSLopMoi.DataSource = busChuyenLop2.getDSLop(MaNH, MaLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không lấy được danh sách lớp cũ!");
            }

        }

        private void dgvDSLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvDSLop.CurrentRow.Index; //dong duoc chon
            MaHS = int.Parse(dgvDSLop[0, row].Value.ToString());
            lMaHS.Add(MaHS);
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            OldMaLop = Convert.ToInt32(cbOldLopHoc.SelectedValue.ToString());
            OldMaNH = Convert.ToInt32(cbOldNamHoc.SelectedValue.ToString());
            MaLop = Convert.ToInt32(cboLopHoc.SelectedValue.ToString());
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue.ToString());
            if (((MaLop / 10) != (OldMaLop / 10)) && MaNH == OldMaNH)
            {
                MessageBox.Show("Không thể chuyển lên lớp khi chưa hết năm học");
            }
            else
            {

                int temp = 0;
                List<int> temps1 = new List<int>();
                foreach (int item in lMaHS)
                {
                    if (busChuyenLop.CheckSiSo(SiSo, MaLop, MaNH) == true)
                    {
                        busChuyenLop.ChuyenLop(item, OldMaLop, OldMaNH, MaLop, MaNH);
                        temp++;
                        temps1.Add(item);
                    }

                }
                if (temp < lMaHS.Count)
                {
                    MessageBox.Show("Sĩ số lớp đã tối đa (" + SiSo + "). Không thể thêm " + (lMaHS.Count - temp) + " học sinh!");
                }
                dgvDSLop.DataSource = busChuyenLop.getDSLop(OldMaNH, OldMaLop);
                dgvDSLopMoi.DataSource = busChuyenLop2.getDSLop(MaNH, MaLop);
                List<DTO_MonHoc> lMonHoc = new List<DTO_MonHoc>();
                lMonHoc = busMonHoc.bgetlistMonHoc();
                List<int> lMaMH = new List<int>();
                for (int i = 0; i < lMonHoc.Count; i++)
                {
                    lMaMH.Add(lMonHoc[i].MaMH);
                }
                foreach (int item in lMaMH)
                {
                    foreach (int i in temps1)
                    {
                        busChuyenLop.insertdataDTBMon(i, OldMaLop, OldMaNH, MaLop, MaNH, item);
                    }
                }
                foreach (int i in temps1)
                {
                    busChuyenLop.updateDTBChung(i, OldMaLop, OldMaNH, MaLop, MaNH);
                }
                lMaHS.Clear();
                lMaMH.Clear();
                lMonHoc.Clear();
                temps1.Clear();
            }
        }
        private void dgvDSLopMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvDSLopMoi.CurrentRow.Index; //dong duoc chon
            MaHS = int.Parse(dgvDSLopMoi[0, row].Value.ToString());
            lMaHS2.Add(MaHS);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OldMaLop = Convert.ToInt32(cbOldLopHoc.SelectedValue.ToString());
            OldMaNH = Convert.ToInt32(cbOldNamHoc.SelectedValue.ToString());
            MaLop = Convert.ToInt32(cboLopHoc.SelectedValue.ToString());
            MaNH = Convert.ToInt32(cboNamHoc.SelectedValue.ToString());
            if (MaLop / 10 != OldMaLop / 10 && MaNH == OldMaNH)
            {
                MessageBox.Show("Không thể chuyển lên lớp khi chưa hết năm học");
            }
            else
            {
                int temp = 0;
                List<int> temps = new List<int>();
                foreach (int item in lMaHS2)
                {
                    if (busChuyenLop2.CheckSiSo(SiSo, OldMaLop, OldMaNH) == true)
                    {
                        busChuyenLop2.ChuyenLop(item, MaLop, MaNH, OldMaLop, OldMaNH);
                        temp++;
                        temps.Add(item);
                    }
                }
                if (temp < lMaHS2.Count)
                    MessageBox.Show("Sĩ số lớp đã tối đa (" + SiSo + "). Không thể thêm " + (lMaHS2.Count - temp) + " học sinh!");
                dgvDSLop.DataSource = busChuyenLop2.getDSLop(OldMaNH, OldMaLop);
                dgvDSLopMoi.DataSource = busChuyenLop2.getDSLop(MaNH, MaLop);
                List<DTO_MonHoc> lMonHoc = new List<DTO_MonHoc>();
                lMonHoc = busMonHoc.bgetlistMonHoc();
                List<int> lMaMH = new List<int>();
                for (int i = 0; i < lMonHoc.Count; i++)
                {
                    lMaMH.Add(lMonHoc[i].MaMH);
                }
                foreach (int item in lMaMH)
                {
                    foreach (int i in temps)
                    {
                        busChuyenLop2.insertdataDTBMon(i, MaLop, MaNH, OldMaLop, OldMaNH, item);
                    }
                }
                foreach (int i in temps)
                {
                    busChuyenLop.updateDTBChung(i, MaLop, MaNH, OldMaLop, OldMaNH);
                }
                lMaMH.Clear();
                lMonHoc.Clear();
                lMaHS2.Clear();
                temps.Clear();
            }
        }
    }
}
//viết tiếp việc chuyển lớp từ bảng này sang bảng kia
