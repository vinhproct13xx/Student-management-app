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

namespace QLHS
{

    public partial class frmTongKet : Form
    {
        /// <summary>
        /// lấy danh sách ở combobox
        /// </summary>
        BUS_MonHoc busMonHoc = new BUS_MonHoc();
        BUS_NamHoc busNamHoc = new BUS_NamHoc();
        BUS_TongKet busTK = new BUS_TongKet();

        DTO_TongKet dtoTK = new DTO_TongKet();

        //mặc định là học kì 1
        /// <summary>
        /// danh sách biến trong các combobox
        /// </summary>
        /// 
        List<DTO_NamHoc> lNamHoc = new List<DTO_NamHoc>();
        List<DTO_MonHoc> lMonHoc = new List<DTO_MonHoc>();

        void HienThiTrongCombobox()
        {
            lNamHoc = busNamHoc.bgetListNamHoc();
            cboNamHoc.DataSource = lNamHoc;
            cboNamHoc.DisplayMember = "tennh";
            cboNamHoc.ValueMember = "manh";
            lMonHoc = busMonHoc.bgetlistMonHoc();
            cboMonHoc.DataSource = lMonHoc;
            cboMonHoc.DisplayMember = "tenmh";
            cboMonHoc.ValueMember = "mamh";
        }
        public frmTongKet()
        {
            InitializeComponent();
        }

        private void frmTongKet_Load(object sender, EventArgs e)
        {
            HienThiTrongCombobox();
            busTK.updateTongKet();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dtoTK.MaMH = Convert.ToInt32(cboMonHoc.SelectedValue.ToString());
            dtoTK.MaNH = Convert.ToInt32(cboNamHoc.SelectedValue.ToString());
            dgvTongKet.DataSource = busTK.getTongKetMon(dtoTK);
        }
    }
}
