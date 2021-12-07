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
    public class DAL_TongKet : DBConnect
    {
        public SqlCommandBuilder sqlComd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public DataTable getTongKetMon(DTO_TongKet tk)
        {
            dt.Clear();
            string sqlSelectTKM = string.Format("select LOPHOC.TENLOP,BAOCAO.SISO,BAOCAO.SOLUONGDAT,TYLE = CAST(round(BAOCAO.TYLE,1) AS VARCHAR(7))+'%' FROM BAOCAO, LOPHOC where  BAOCAO.MAMH = {0} AND BAOCAO.MALOP = LOPHOC.MALOP and BAOCAO.MANH = {1}", tk.MaMH,tk.MaNH, _conn);
            try
            {
                da = new SqlDataAdapter(sqlSelectTKM, _conn);
                da.Fill(dt);
                if(dt.Rows.Count==0)
                {
                    MessageBox.Show("Lớp chưa có điểm hoặc chưa tạo lớp!!!");
                }
            }
            catch
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu!!");
            }
            return dt;
        }
        public DataTable getTongKetChung(DTO_TongKet tk)
        {
            dt.Clear();
            string sqlSelectTKc = string.Format("select LOPHOC.TENLOP,SISO=BAOCAOCHUNG.SISO,SOLUONGDAT=BAOCAOCHUNG.SOLUONGDAT,TYLE = CAST(ROUND(BAOCAOCHUNG.TYLE,1) AS VARCHAR(10))+'%' FROM BAOCAOCHUNG, LOPHOC where  BAOCAOCHUNG.MALOP = LOPHOC.MALOP and BAOCAOCHUNG.MANH = {0}", tk.MaNH, _conn);
            try
            {
                da = new SqlDataAdapter(sqlSelectTKc, _conn);
                da.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Lớp chưa có điểm!!!");
                }
            }
            catch
            {
                MessageBox.Show("Không thể lấy cơ sở dữ liệu!!");
            }
            return dt;
        }
        public void updateTongKet()
        {
            string sqlUpdateSiSo = string.Format("UPDATE BAOCAO SET SISO = (SELECT COUNT(DISTINCT(DIEMTBMON.MAHS)) FROM DIEMTBMON WHERE BAOCAO.MANH = DIEMTBMON.MANH AND BAOCAO.MALOP = DIEMTBMON.MALOP)", _conn);
            string sqlUpdateSoLuongDat = string.Format("UPDATE BAOCAO SET SOLUONGDAT = (SELECT COUNT(DIEMTBMON.CANAM) FROM DIEMTBMON WHERE BAOCAO.MANH = DIEMTBMON.MANH AND BAOCAO.MALOP = DIEMTBMON.MALOP AND DIEMTBMON.CANAM >= 5 AND DIEMTBMON.MAMH = BAOCAO.MAMH)", _conn);
            string sqlUpdateTyLe = string.Format("UPDATE BAOCAO SET TYLE = SOLUONGDAT / SISO * 100", _conn);
            SqlCommand cmdUpdateSiSo = new SqlCommand(sqlUpdateSiSo, _conn);
            SqlCommand cmdUpdateSoLuongDat = new SqlCommand(sqlUpdateSoLuongDat, _conn);
            SqlCommand cmdUpdateTyLe = new SqlCommand(sqlUpdateTyLe, _conn);
            _conn.Open();
            //try
            //{
                cmdUpdateSiSo.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu sĩ số!!");
            //}
            
            //try
            //{
                cmdUpdateSoLuongDat.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu số lượng đạt!!");
            //}
             
            //try
            //{
                cmdUpdateTyLe.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu tỷ lệ!!");
            //}
            _conn.Close();
        }
        public void updateTongKetChung()
        {
            string sqlUpdateSiSo = string.Format("UPDATE BAOCAOCHUNG SET SISO = (SELECT COUNT(DISTINCT(DIEMTBMON.MAHS)) FROM DIEMTBMON WHERE BAOCAOCHUNG.MANH = DIEMTBMON.MANH AND BAOCAOCHUNG.MALOP = DIEMTBMON.MALOP) ", _conn);
            string sqlUpdateSoLuongDat = string.Format("UPDATE BAOCAOCHUNG SET SOLUONGDAT = (SELECT COUNT(DIEMTBCHUNG.CANAM) FROM DIEMTBCHUNG WHERE BAOCAOCHUNG.MANH = DIEMTBCHUNG.MANH AND BAOCAOCHUNG.MALOP = DIEMTBCHUNG.MALOP AND DIEMTBCHUNG.CANAM >= 5)", _conn);
            string sqlUpdateTyLe = string.Format("UPDATE BAOCAOCHUNG SET TYLE = SOLUONGDAT / SISO * 100", _conn);
            SqlCommand cmdUpdateSiSo = new SqlCommand(sqlUpdateSiSo, _conn);
            SqlCommand cmdUpdateSoLuongDat = new SqlCommand(sqlUpdateSoLuongDat, _conn);
            SqlCommand cmdUpdateTyLe = new SqlCommand(sqlUpdateTyLe, _conn);
            _conn.Open();
            //try
            //{
                cmdUpdateSiSo.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu sĩ số!!");
            //}
            //try
            //{
                cmdUpdateSoLuongDat.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu số lượng đạt!!");
            //}
            //try
            //{
                cmdUpdateTyLe.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("Không thể update dữ liệu tỷ lệ!!");
            //}
            _conn.Close();
        }
    }
}
