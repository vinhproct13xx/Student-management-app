using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QLHS
{
    public partial class frmDTBChung : Form
    {
        public frmDTBChung()
        {
            InitializeComponent();
        }

        /// <summary>
        /// lấy danh sách ở combobox
        /// </summary>
        BUS_LopHoc busLopHoc = new BUS_LopHoc();
        BUS_NamHoc busNamHoc = new BUS_NamHoc();
        BUS_DTB busDTB = new BUS_DTB();

        DTO_DTB dtoDTB = new DTO_DTB();

        //mặc định là học kì 1
        /// <summary>
        /// danh sách biến trong các combobox
        /// </summary>
        /// 
        List<DTO_NamHoc> lNamHoc = new List<DTO_NamHoc>();
        List<DTO_LopHoc> lLopHoc = new List<DTO_LopHoc>();

        void HienThiTrongCombobox()
        {
            lNamHoc = busNamHoc.bgetListNamHoc();
            cbNamHoc.DataSource = lNamHoc;
            cbNamHoc.DisplayMember = "tennh";
            cbNamHoc.ValueMember = "manh";
            lLopHoc = busLopHoc.bgetlistLopHoc();
            cbLopHoc.DataSource = lLopHoc;
            cbLopHoc.DisplayMember = "tenlop";
            cbLopHoc.ValueMember = "malop";
        }
        private void frmDTBChung_Load(object sender, EventArgs e)
        {
            HienThiTrongCombobox();
            busDTB.updateDTB();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dtoDTB.MaLop = Convert.ToInt32(cbLopHoc.SelectedValue.ToString());
            dtoDTB.MaNH = Convert.ToInt32(cbNamHoc.SelectedValue.ToString());
            //dgvDTB.DataSource = null;
            dgvDTB.DataSource = busDTB.getDTBChung(dtoDTB);
        }
    }
}
