using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_TaoLop : DBConnect
    {
        /// <summary>
        /// get toan bo hoc sinh chua co lop
        /// </summary>
        /// <returns>danh sach hoc sinh</returns>

        public DataTable getDanhSachLop()
        {
            //  _conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select HOCSINH.mahs, HOCSINH.hoten  from hocsinh where mahs not in ( select mahs from chitietlop)", _conn);
            DataTable dtDanhSachLop = new DataTable();
            da.Fill(dtDanhSachLop);
            //_conn.Close();
            return dtDanhSachLop;

        }
        public DataTable getDanhSachLopCoSan(int NamHoc, int Lop)
        {
            //_conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop where malop = " + Lop + "and manh = " + NamHoc + ")", _conn);
            DataTable dtDanhSachLopCoSan = new DataTable();
            da.Fill(dtDanhSachLopCoSan);
            //_conn.Close();
            return dtDanhSachLopCoSan;
        }
        public DataTable LopHoc()
        {
            //_conn.Open();
            SqlDataAdapter dr = new SqlDataAdapter("select malop, tenlop from Lophoc", _conn);
            DataTable dtLopHoc = new DataTable();
            dr.Fill(dtLopHoc);
            //_conn.Close();
            return dtLopHoc;
        }
        public void ChuyenLop(int mahs, int malop, int manh)
        {
            string sql = "insert into chitietlop values (" + mahs + ", " + malop + ", " + manh + ")";
            _conn.Open();
            SqlCommand cmd = new SqlCommand(sql, _conn);
            try
            {
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Chuyển lớp không thành công");
            }
            _conn.Close();

        }
        
        public bool CheckSiSo(int SiSo, int malop, int manh)
        {
            string sql = " select count(mahs) from chitietlop where malop = " + malop + " and manh = " + manh;
            int i;
            SqlCommand cmd = new SqlCommand(sql, _conn);
            _conn.Open();
            i = (int)cmd.ExecuteScalar();
            _conn.Close();
            if (i < SiSo)
                return true;
            return false;

        }
        public void InsertData(int manh, int malop, int mamh, int mahs)
        {
            string sqlCommand = "insert into DIEMTBMON values ( " + manh + ", " + malop + ", " + mamh + ", " + mahs + ", NULL, NULL, NULL )";
            _conn.Open();
            try
            {           
                SqlCommand cmd = new SqlCommand(sqlCommand, _conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            _conn.Close();
        }
        public void InsertDiemTBChung(int manh, int malop, int mahs)
        {
            string sqlDiemTBChung = string.Format("INSERT INTO DIEMTBCHUNG VALUES ({0},{1},{2},NULL,NULL,NULL)", manh, malop, mahs, _conn);
            _conn.Open();
            try
            {
                SqlCommand cmdDiemTBChung = new SqlCommand(sqlDiemTBChung, _conn);
                cmdDiemTBChung.ExecuteNonQuery();
            }
            catch
            {
            }
            _conn.Close();
        }
        public void InsertBaoCaoChung(int manh, int malop)
        {
            string sqlBaoCaoChung = string.Format("INSERT INTO BAOCAOCHUNG VALUES ({0},{1},NULL,NULL,NULL)", manh, malop, _conn);
            _conn.Open();
            try
            {
                SqlCommand cmdBaoCaoChung = new SqlCommand(sqlBaoCaoChung, _conn);
                cmdBaoCaoChung.ExecuteNonQuery();
            }
            catch
            {
            }
            _conn.Close();
        }
        public void InsertBaoCao(int manh, int malop, int mamh)
        {
            string sqlBaoCao = string.Format("INSERT INTO BAOCAO VALUES ({0},{1},{2},NULL,NULL,NULL)",manh,malop,mamh, _conn);
            _conn.Open();
            try
            {
                SqlCommand cmdBaoCao = new SqlCommand(sqlBaoCao, _conn);
                cmdBaoCao.ExecuteNonQuery();
            }
            catch
            {
            }
            _conn.Close();
        }
    }
}
