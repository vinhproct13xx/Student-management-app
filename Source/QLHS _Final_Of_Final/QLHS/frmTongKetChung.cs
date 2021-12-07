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
    public partial class frmTongKetChung : Form
    {
        /// <summary>
        /// lấy danh sách ở combobox
        /// </summary>
        BUS_NamHoc busNamHoc = new BUS_NamHoc();
        BUS_TongKet busTK = new BUS_TongKet();

        DTO_TongKet dtoTK = new DTO_TongKet();

        //mặc định là học kì 1
        /// <summary>
        /// danh sách biến trong các combobox
        /// </summary>
        /// 
        List<DTO_NamHoc> lNamHoc = new List<DTO_NamHoc>();

        void HienThiTrongCombobox()
        {
            lNamHoc = busNamHoc.bgetListNamHoc();
            cboNamHoc.DataSource = lNamHoc;
            cboNamHoc.DisplayMember = "tennh";
            cboNamHoc.ValueMember = "manh";
        }
        public frmTongKetChung()
        {
            InitializeComponent();
        }

        private void frmTongKetChung_Load(object sender, EventArgs e)
        {
            HienThiTrongCombobox();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            busTK.updateTongKetChung();
            dtoTK.MaNH = Convert.ToInt32(cboNamHoc.SelectedValue.ToString());
            dgvTongKet.DataSource = busTK.getTongKetChung(dtoTK);
        }
    }
}
