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
            string sqlBangDiem = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,1,'Mieng',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem2 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,1,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem3 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,2,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem4 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},1,3,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem5 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,1,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem6 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,2,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem7 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},2,3,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem8 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},1,{2},{3},3,1,'DiemThi',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem9 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,1,'Mieng',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem10 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,1,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem11 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,2,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem12 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},1,3,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem13 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,1,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem14 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,2,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem15 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},2,3,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem16 = string.Format("INSERT INTO BANGDIEM VALUES ({0},{1},2,{2},{3},3,1,'DiemThi',NULL)", manh, malop, mamh, mahs);
            SqlCommand cmd = new SqlCommand(sqlCommand, _conn);
            SqlCommand cmdBangDiem = new SqlCommand(sqlBangDiem, _conn);
            SqlCommand cmdBangDiem2 = new SqlCommand(sqlBangDiem2, _conn);
            SqlCommand cmdBangDiem3 = new SqlCommand(sqlBangDiem3, _conn);
            SqlCommand cmdBangDiem4 = new SqlCommand(sqlBangDiem4, _conn);
            SqlCommand cmdBangDiem5 = new SqlCommand(sqlBangDiem5, _conn);
            SqlCommand cmdBangDiem6 = new SqlCommand(sqlBangDiem6, _conn);
            SqlCommand cmdBangDiem7 = new SqlCommand(sqlBangDiem7, _conn);
            SqlCommand cmdBangDiem8 = new SqlCommand(sqlBangDiem8, _conn);
            SqlCommand cmdBangDiem9 = new SqlCommand(sqlBangDiem9, _conn);
            SqlCommand cmdBangDiem10 = new SqlCommand(sqlBangDiem10, _conn);
            SqlCommand cmdBangDiem11 = new SqlCommand(sqlBangDiem11, _conn);
            SqlCommand cmdBangDiem12 = new SqlCommand(sqlBangDiem12, _conn);
            SqlCommand cmdBangDiem13 = new SqlCommand(sqlBangDiem13, _conn);
            SqlCommand cmdBangDiem14 = new SqlCommand(sqlBangDiem14, _conn);
            SqlCommand cmdBangDiem15 = new SqlCommand(sqlBangDiem15, _conn);
            SqlCommand cmdBangDiem16 = new SqlCommand(sqlBangDiem16, _conn);
            _conn.Open();
            try
            {           
                cmd.ExecuteNonQuery();
                cmdBangDiem.ExecuteNonQuery();
                cmdBangDiem2.ExecuteNonQuery();
                cmdBangDiem3.ExecuteNonQuery();
                cmdBangDiem4.ExecuteNonQuery();
                cmdBangDiem5.ExecuteNonQuery();
                cmdBangDiem6.ExecuteNonQuery();
                cmdBangDiem7.ExecuteNonQuery();
                cmdBangDiem8.ExecuteNonQuery();
                cmdBangDiem9.ExecuteNonQuery();
                cmdBangDiem10.ExecuteNonQuery(); 
                cmdBangDiem11.ExecuteNonQuery();
                cmdBangDiem12.ExecuteNonQuery();
                cmdBangDiem13.ExecuteNonQuery(); 
                cmdBangDiem14.ExecuteNonQuery();
                cmdBangDiem15.ExecuteNonQuery();
                cmdBangDiem16.ExecuteNonQuery();
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
        public void InsertBangDiem(int manh, int malop, int mamh,int mahs)
        {
            string sqlBangDiem = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},1,1,'Mieng',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem2 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},1,1,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem3 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},1,2,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem4 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},1,3,'Diem15p',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem5 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},2,1,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem6 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},2,2,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem7 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},2,3,'Diem1T',NULL)", manh, malop, mamh, mahs);
            string sqlBangDiem8 = string.Format("INSERT INTO BANGDIEM VALUES ({1},{2},1,{3},{4},3,1,'DiemThi',NULL)", manh, malop, mamh, mahs);
            _conn.Open();
            SqlCommand cmdBangDiem = new SqlCommand(sqlBangDiem, _conn);
            SqlCommand cmdBangDiem2 = new SqlCommand(sqlBangDiem2, _conn);
            SqlCommand cmdBangDiem3 = new SqlCommand(sqlBangDiem3, _conn);
            SqlCommand cmdBangDiem4 = new SqlCommand(sqlBangDiem4, _conn);
            SqlCommand cmdBangDiem5 = new SqlCommand(sqlBangDiem5, _conn);
            SqlCommand cmdBangDiem6 = new SqlCommand(sqlBangDiem6, _conn);
            SqlCommand cmdBangDiem7 = new SqlCommand(sqlBangDiem7, _conn);
            SqlCommand cmdBangDiem8 = new SqlCommand(sqlBangDiem8, _conn);
            try
            {
                cmdBangDiem.ExecuteNonQuery();
                cmdBangDiem2.ExecuteNonQuery();
                cmdBangDiem3.ExecuteNonQuery();
                cmdBangDiem4.ExecuteNonQuery();
                cmdBangDiem5.ExecuteNonQuery();
                cmdBangDiem6.ExecuteNonQuery();
                cmdBangDiem7.ExecuteNonQuery();
                cmdBangDiem8.ExecuteNonQuery();
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
