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
            SqlDataAdapter da = new SqlDataAdapter("select mahs, hoten from hocsinh where mahs  in  (select mahs from chitietlop where malop = " + Lop + "and manh = " + NamHoc+ ")", _conn);
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

        public void InsertData(int manh, int malop, int mamh, int mahs)
        {
            string sqlCommand = "insert into DIEMTBMON values ( " + manh + ", " + malop + ", " + mamh + ", " + mahs + ", NULL, NULL, NULL )";
            //MessageBox.Show(sqlCommand);
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, _conn);
                cmd.ExecuteNonQuery();
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ thống chưa thể tính điểm trung bình! ");
            }
        }
    }
}
