using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;

namespace DAL
{
    public class DAL_TiepNhanHocSinh : DBConnect
    {
        /// <summary>
        /// Get toàn bộ thành viên
        /// </summary>
        /// <returns></returns>
        public DataTable getHocSinh()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HSHS", _conn);
            DataTable dtHocSinh = new DataTable();
            da.Fill(dtHocSinh);
            return dtHocSinh;
        }

        /// <summary>
        /// Thêm học sinh
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public bool themHocSinh(DTO_TiepNhanHocSinh hs)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO HSHS(HOTEN,DIACHI,NGAYSINH,GIOITINH,TONGIAO,DANTOC,HOTENCHA,NGHENGHIEPCHA,HOTENME,NGHENGHIEPME,MANAMHOC) VALUES (N'{0}',N'{1}','{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}', N'{9}',{10})", hs.HOTEN, hs.DIACHI,hs.NGAYSINH,hs.GIOITINH,hs.TONGIAO,hs.DANTOC,hs.HOTENCHA,hs.NGHENGHIEPCHA,hs.HOTENME,hs.NGHENGHIEPME,hs.MANAMHOC);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa học sinh
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public bool suaHocSinh(DTO_TiepNhanHocSinh hs)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE HSHS SET HOTEN = N'{1}', DIACHI = N'{2}', NGAYSINH = '{3}', GIOITINH = N'{4}', TONGIAO = N'{5}', DANTOC = N'{6}', HOTENCHA=N'{7}',NGHENGHIEPCHA=N'{8}',HOTENME=N'{9}',NGHENGHIEPME=N'{10}',MANAMHOC={11} WHERE MAHS = {0}", hs.MAHS, hs.HOTEN, hs.DIACHI, hs.NGAYSINH, hs.GIOITINH, hs.TONGIAO, hs.DANTOC, hs.HOTENCHA, hs.NGHENGHIEPCHA, hs.HOTENME, hs.NGHENGHIEPME, hs.MANAMHOC);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Xóa học sinh
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public bool xoaHocSinh(int hs_mahs, int hs_namhoc )
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM HSHS WHERE (MAHS = {0}) and (MANAMHOC = {1})", hs_mahs, hs_namhoc);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }
    }
}
