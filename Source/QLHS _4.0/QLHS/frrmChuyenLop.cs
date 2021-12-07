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

        /// <summary>
        /// biến chung, truyền vào làm đối số cho các hàm
        /// </summary>
        int MaHS;
        int OldMaLop;
        int OldMaNH;
        int MaLop;
        int MaNH;
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

        private void dgvDSLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmChuyenLop_Load(object sender, EventArgs e)
        {
            HienThiLop();
            HienThiNamHoc();

        }

        private void btnXem1_Click(object sender, EventArgs e)
        {
            OldMaNH = Convert.ToInt32(cbOldNamHoc.SelectedValue);
            OldMaLop = Convert.ToInt32(cbOldLopHoc.SelectedValue);
            try
            {
                dgvDSLop.DataSource = busChuyenLop.getDSLop(OldMaNH, OldMaLop);
            }catch(Exception ex)
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
            foreach (int item in lMaHS)

            {
                busChuyenLop.ChuyenLop(item, OldMaLop, OldMaNH, MaLop, MaNH);
            }
            dgvDSLop.DataSource = busChuyenLop.getDSLop(OldMaNH, OldMaLop);
            dgvDSLopMoi.DataSource = busChuyenLop2.getDSLop(MaNH, MaLop);
            lMaHS = new List<int>();
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
            foreach (int item in lMaHS2)

            {
                busChuyenLop2.ChuyenLop(item, MaLop, MaNH, OldMaLop, OldMaNH);
            }
            dgvDSLop.DataSource = busChuyenLop2.getDSLop(OldMaNH, OldMaLop);
            dgvDSLopMoi.DataSource = busChuyenLop2.getDSLop(MaNH, MaLop);
            lMaHS2 = new List<int>();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbOldLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbOldNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//viết tiếp việc chuyển lớp từ bảng này sang bảng kia
