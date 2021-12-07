using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_DTB : DBConnect
    {
        public SqlCommandBuilder sqlComd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public DataTable getDTB(DTO_DTB dtb)
        {
            dt.Clear();
            try
            {
                string sqlSelect = string.Format("SELECT  DIEMTBMON.MAHS,HOCSINH.HOTEN,TBHK1=ROUND(DIEMTBMON.TBHK1,1), TBHK2= ROUND(DIEMTBMON.TBHK2,1),CANAM= ROUND(DIEMTBMON.CANAM,1) FROM DIEMTBMON, HOCSINH WHERE DIEMTBMON.MAHS = HOCSINH.MAHS AND DIEMTBMON.MANH = {0} AND DIEMTBMON.MALOP = {1} AND DIEMTBMON.MAMH = {2}", dtb.MaNH,dtb.MaLop,dtb.MaMH, _conn);
                da = new SqlDataAdapter(sqlSelect, _conn);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Lớp chưa có điểm!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu mã lớp");
            }
            return dt;
        }
        public void updateDTB()
        {
            try
            {
                string sqlUpdateTBHK1 = string.Format("update DIEMTBMON SET TBHK1 = (SELECT DTB = (SUM(BANGDIEM.DIEM * BANGDIEM.HESO) / SUM(BANGDIEM.HESO)) FROM BANGDIEM WHERE BANGDIEM.MAHK = 1 AND DIEMTBMON.MANH = BANGDIEM.MANH AND DIEMTBMON.MALOP = BANGDIEM.MALOP AND DIEMTBMON.MAHS = BANGDIEM.MAHS AND DIEMTBMON.MAMH = BANGDIEM.MAMH)", _conn);
                string sqlUpdateTBHK2 = string.Format("update DIEMTBMON SET TBHK2 = (SELECT DTB = (SUM(BANGDIEM.DIEM * BANGDIEM.HESO) / SUM(BANGDIEM.HESO)) FROM BANGDIEM WHERE BANGDIEM.MAHK = 2 AND DIEMTBMON.MANH = BANGDIEM.MANH AND DIEMTBMON.MALOP = BANGDIEM.MALOP AND DIEMTBMON.MAHS = BANGDIEM.MAHS AND DIEMTBMON.MAMH = BANGDIEM.MAMH)", _conn);
                string sqlUpdateCaNam = string.Format("update DIEMTBMON SET CANAM = (TBHK1 + TBHK2) / 2", _conn);
                string sqlUpdateTBHK1Chung = string.Format("UPDATE DIEMTBCHUNG SET TBHK1 = (SELECT DTB = (AVG(DIEMTBMON.TBHK1)) FROM DIEMTBMON WHERE DIEMTBMON.MANH = DIEMTBCHUNG.MANH AND DIEMTBMON.MALOP = DIEMTBCHUNG.MALOP)", _conn);
                string sqlUpdateTBHK2Chung = string.Format("UPDATE DIEMTBCHUNG SET TBHK2 = (SELECT DTB = (AVG(DIEMTBMON.TBHK2)) FROM DIEMTBMON WHERE DIEMTBMON.MANH = DIEMTBCHUNG.MANH AND DIEMTBMON.MALOP = DIEMTBCHUNG.MALOP)", _conn);
                string sqlUpdateCaNamChung = string.Format("UPDATE DIEMTBCHUNG SET CANAM = (TBHK1 + TBHK2) / 2",_conn);
                _conn.Open();
                SqlCommand cmdUpdateTBHK1 = new SqlCommand(sqlUpdateTBHK1, _conn);
                SqlCommand cmdUpdateTBHK2 = new SqlCommand(sqlUpdateTBHK2, _conn);
                SqlCommand cmdUpdateCaNam = new SqlCommand(sqlUpdateCaNam, _conn);
                SqlCommand cmdUpdateTBHK1Chung = new SqlCommand(sqlUpdateTBHK1Chung, _conn);
                SqlCommand cmdUpdateTBHK2Chung = new SqlCommand(sqlUpdateTBHK2Chung, _conn);
                SqlCommand cmdUpdateCaNamChung = new SqlCommand(sqlUpdateCaNamChung, _conn);
                cmdUpdateTBHK1.ExecuteNonQuery();
                cmdUpdateTBHK2.ExecuteNonQuery();
                cmdUpdateCaNam.ExecuteNonQuery();
                cmdUpdateTBHK1Chung.ExecuteNonQuery();
                cmdUpdateTBHK2Chung.ExecuteNonQuery();
                cmdUpdateCaNamChung.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể update dữ liệu!");
            }
        }
        public DataTable getDTBChung(DTO_DTB dtb)
        {
            dt.Clear();
            try
            {
                string sqlSelect = string.Format("SELECT  DIEMTBMON.MAHS,HOCSINH.HOTEN,TBHK1=ROUND(AVG(DIEMTBMON.TBHK1),1),TBHK2=ROUND(AVG(DIEMTBMON.TBHK2),1),CANAM=ROUND(((AVG(DIEMTBMON.TBHK1)+AVG(DIEMTBMON.TBHK2))/2),1) FROM DIEMTBMON, HOCSINH WHERE DIEMTBMON.MAHS = HOCSINH.MAHS AND DIEMTBMON.MANH = {0} AND DIEMTBMON.MALOP = {1} GROUP BY DIEMTBMON.MAHS, HOCSINH.HOTEN", dtb.MaNH,dtb.MaLop, _conn);
                da = new SqlDataAdapter(sqlSelect, _conn);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Lớp chưa có điểm!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu mã lớp");
            }
            return dt;
        }

    }
}
